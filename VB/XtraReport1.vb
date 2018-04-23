Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing.Text

Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private images As New Hashtable()
        Private sbRed As New SolidBrush(Color.Red)
        Private font As New Font("Segoe UI", 18)
        Private sbBlack As New SolidBrush(Color.Black)
        Private sbWhite As New SolidBrush(Color.White)

        Private Sub xrPivotGrid1_PrintCell(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs) Handles xrPivotGrid1.PrintCell
            If e.Value IsNot Nothing AndAlso CInt((e.Value)) > 0 Then
                Dim tb As DevExpress.XtraPrinting.TextBrick = TryCast(e.Brick, DevExpress.XtraPrinting.TextBrick)
                Dim ib As DevExpress.XtraPrinting.ImageBrick = TryCast(tb.PrintingSystem.CreateBrick("ImageBrick"), DevExpress.XtraPrinting.ImageBrick)
                ib.Rect = DevExpress.XtraPrinting.GraphicsUnitConverter.DocToPixel(e.Brick.Rect)
                tb.IsVisible = False
                Dim im As Image = GetImageByValue(CInt((e.Value)), ib.Rect)
                ib.Image = im
                ib.SizeMode = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
                tb.PrintingSystem.Graph.DrawBrick(ib)
            End If
        End Sub

        Private Function GetImageByValue(ByVal value As Integer, ByVal rect As RectangleF) As Image
            If images.Contains(value) Then
                Return TryCast(images(value), Image)
            Else
                Dim bmp As New Bitmap(CInt(rect.Width)*2, CInt(rect.Height)*2)
                Using gr As Graphics = Graphics.FromImage(bmp)
                    Dim max As Integer = If(value>100, 100, value)
                    gr.FillRectangle(sbWhite, New Rectangle(0, 0, CInt(rect.Width) * 2, CInt(rect.Height) * 2))
                    gr.FillRectangle(sbRed, New Rectangle(0, 0, CInt(((rect.Width*max) \ 100+0.5))*2,CInt(rect.Height)*2))
                    gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                    gr.DrawString(value.ToString(), font, sbBlack, New Rectangle(CInt(rect.Width), 0, CInt(rect.Width) * 2, CInt(rect.Height) * 2), StringFormat.GenericTypographic)
                End Using
                images.Add(value, bmp)
                Return bmp
            End If
        End Function
    End Class
End Namespace
