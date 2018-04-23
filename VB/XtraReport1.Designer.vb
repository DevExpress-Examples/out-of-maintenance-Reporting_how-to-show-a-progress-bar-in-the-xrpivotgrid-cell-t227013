Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo15 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo16 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo17 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.fieldOrderID1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldOrderDate1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldShipRegion1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "localhost_NorthwindConnection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Products"
            tableInfo1.Name = "Products"
            columnInfo1.Name = "ProductID"
            columnInfo2.Name = "ProductName"
            columnInfo3.Name = "SupplierID"
            columnInfo4.Name = "CategoryID"
            columnInfo5.Name = "QuantityPerUnit"
            columnInfo6.Name = "UnitPrice"
            columnInfo7.Name = "UnitsInStock"
            columnInfo8.Name = "UnitsOnOrder"
            columnInfo9.Name = "ReorderLevel"
            columnInfo10.Name = "Discontinued"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            tableQuery2.Name = "Orders"
            tableInfo2.Name = "Orders"
            columnInfo11.Name = "OrderID"
            columnInfo12.Name = "OrderDate"
            columnInfo13.Name = "ShipAddress"
            columnInfo14.Name = "ShipCity"
            columnInfo15.Name = "ShipRegion"
            columnInfo16.Name = "ShipPostalCode"
            columnInfo17.Name = "ShipCountry"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15, columnInfo16, columnInfo17})
            tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' formattingRule1
            ' 
            Me.formattingRule1.Condition = "[DataSource.CurrentRowIndex]==[DataSource.RowCount]-1"
            ' 
            ' 
            ' 
            Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False
            Me.formattingRule1.Name = "formattingRule1"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 47.5F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 48.66666F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 1R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 1R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 1R
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
            Me.ReportFooter.HeightF = 148.3333F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrPivotGrid1
            ' 
            Me.xrPivotGrid1.DataMember = "Orders"
            Me.xrPivotGrid1.DataSource = Me.sqlDataSource1
            Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldOrderID1, Me.fieldOrderDate1, Me.fieldShipRegion1})
            Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPivotGrid1.Name = "xrPivotGrid1"
            Me.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
            Me.xrPivotGrid1.Scripts.OnPrintFieldValue = "xrPivotGrid1_PrintFieldValue"
            Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(650F, 148.3333F)
            ' 
            ' fieldOrderID1
            ' 
            Me.fieldOrderID1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldOrderID1.AreaIndex = 0
            Me.fieldOrderID1.Caption = "Order ID"
            Me.fieldOrderID1.FieldName = "OrderID"
            Me.fieldOrderID1.Name = "fieldOrderID1"
            Me.fieldOrderID1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            ' 
            ' fieldOrderDate1
            ' 
            Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate1.AreaIndex = 0
            Me.fieldOrderDate1.Caption = "Order Date"
            Me.fieldOrderDate1.ColumnValueLineCount = 5
            Me.fieldOrderDate1.FieldName = "OrderDate"
            Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonthYear
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            Me.fieldOrderDate1.RowValueLineCount = 5
            Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
            Me.fieldOrderDate1.ValueFormat.FormatString = "MMM, yyyy"
            Me.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.fieldOrderDate1.Width = 50
            ' 
            ' fieldShipRegion1
            ' 
            Me.fieldShipRegion1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldShipRegion1.AreaIndex = 0
            Me.fieldShipRegion1.Caption = "Ship Region"
            Me.fieldShipRegion1.FieldName = "ShipRegion"
            Me.fieldShipRegion1.Name = "fieldShipRegion1"
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataMember = "Orders"
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedField1})
            Me.DataMember = "Orders"
            Me.DataSource = Me.sqlDataSource1
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 48, 49)
            Me.ScriptsSource = ControlChars.CrLf & "private void xrPivotGrid1_PrintFieldValue(object sender, DevExpress.XtraReports" & ".UI.PivotGrid.CustomExportFieldValueEventArgs e) {" & ControlChars.CrLf & "       }" & ControlChars.CrLf
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
        Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField
        Private WithEvents xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
        Private fieldOrderID1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldOrderDate1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldShipRegion1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    End Class
End Namespace
