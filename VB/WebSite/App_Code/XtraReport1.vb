Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport

	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrLabel1 As XRLabel
	Private xrLabel2 As XRLabel
	Private xrLabel3 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	Private dataSet11 As DataSet1
	Private categoriesTableAdapter1 As DataSet1TableAdapters.CategoriesTableAdapter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

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
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.dataSet11 = New DataSet1()
		Me.categoriesTableAdapter1 = New DataSet1TableAdapters.CategoriesTableAdapter()
		DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel2})
		Me.Detail.Height = 142
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
		Me.xrPictureBox1.Location = New System.Drawing.Point(500, 42)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.Size = New System.Drawing.Size(133, 67)
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
		Me.xrLabel3.Location = New System.Drawing.Point(25, 83)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.Size = New System.Drawing.Size(392, 25)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
		Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel2.ForeColor = System.Drawing.Color.Blue
		Me.xrLabel2.Location = New System.Drawing.Point(25, 42)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.Size = New System.Drawing.Size(183, 25)
		Me.xrLabel2.StylePriority.UseFont = False
		Me.xrLabel2.StylePriority.UseForeColor = False
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' PageHeader
		' 
		Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.PageHeader.Height = 42
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 25F)
		Me.xrLabel1.Location = New System.Drawing.Point(250, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(158, 42)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Categories"
		' 
		' PageFooter
		' 
		Me.PageFooter.Height = 30
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' categoriesTableAdapter1
		' 
		Me.categoriesTableAdapter1.ClearBeforeFill = True
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.DataAdapter = Me.categoriesTableAdapter1
		Me.DataMember = "Categories"
		Me.DataSource = Me.dataSet11
		Me.Version = "8.2"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReport1_BeforePrint);
		DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
		'DataSet1TableAdapters.CategoriesTableAdapter da = new DataSet1TableAdapters.CategoriesTableAdapter();
		'DataSet1 ds = new DataSet1();

		'da.Fill(ds.Categories);

		'DataSource = ds.Categories;

		'xrLabel2.Text = "[CategoryName]";
		'xrLabel3.Text = "[Description]";
		'xrPictureBox1.DataBindings.Add("Image", null, "Picture");
	End Sub
End Class
