using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        Hashtable images = new Hashtable();
        SolidBrush sbRed = new SolidBrush(Color.Red);
        Font font = new Font("Segoe UI", 18);
        SolidBrush sbBlack = new SolidBrush(Color.Black);
        SolidBrush sbWhite = new SolidBrush(Color.White);
     
        private void xrPivotGrid1_PrintCell(object sender, DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs e)
        {
            if (e.Value != null && (int)e.Value > 0)
            {
                DevExpress.XtraPrinting.TextBrick tb = e.Brick as DevExpress.XtraPrinting.TextBrick;
                DevExpress.XtraPrinting.ImageBrick ib = tb.PrintingSystem.CreateBrick("ImageBrick") as DevExpress.XtraPrinting.ImageBrick;
                ib.Rect = DevExpress.XtraPrinting.GraphicsUnitConverter.DocToPixel(e.Brick.Rect);
                tb.IsVisible = false;
                Image im = GetImageByValue((int)e.Value, ib.Rect);
                ib.Image = im;
                ib.SizeMode = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
                tb.PrintingSystem.Graph.DrawBrick(ib);
            }
        }
    
        private Image GetImageByValue(int value, RectangleF rect)
        {
            if (images.Contains(value))
                return images[value] as Image;
            else
            {
                Bitmap bmp = new Bitmap((int)rect.Width*2, (int)rect.Height*2);
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    int max = value>100?100:value;
                    gr.FillRectangle(sbWhite, new Rectangle(0, 0, (int) rect.Width * 2, (int)rect.Height * 2));
                    gr.FillRectangle(sbRed, new Rectangle(0, 0, (int)((rect.Width*max) / 100+0.5)*2,(int) rect.Height*2));
                    gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    gr.DrawString(value.ToString(), font, sbBlack, new Rectangle((int)rect.Width, 0, (int)rect.Width * 2, (int)rect.Height * 2), StringFormat.GenericTypographic);
                }
                images.Add(value, bmp);
                return bmp;
            }
        }
    }
}
