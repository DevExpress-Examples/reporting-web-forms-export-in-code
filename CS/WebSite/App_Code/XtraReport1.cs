using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
	private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private DataSet1 dataSet11;
    private DataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport1()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "XtraReport1.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.dataSet11 = new DataSet1();
        this.categoriesTableAdapter1 = new DataSet1TableAdapters.CategoriesTableAdapter();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel3,
            this.xrLabel2});
        this.Detail.Height = 142;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Categories.Picture", "")});
        this.xrPictureBox1.Location = new System.Drawing.Point(500, 42);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.Size = new System.Drawing.Size(133, 67);
        // 
        // xrLabel3
        // 
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.Description", "")});
        this.xrLabel3.Location = new System.Drawing.Point(25, 83);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.Size = new System.Drawing.Size(392, 25);
        this.xrLabel3.Text = "xrLabel3";
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Categories.CategoryName", "")});
        this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.xrLabel2.ForeColor = System.Drawing.Color.Blue;
        this.xrLabel2.Location = new System.Drawing.Point(25, 42);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.Size = new System.Drawing.Size(183, 25);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseForeColor = false;
        this.xrLabel2.Text = "xrLabel2";
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.PageHeader.Height = 42;
        this.PageHeader.Name = "PageHeader";
        this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 25F);
        this.xrLabel1.Location = new System.Drawing.Point(250, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(158, 42);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "Categories";
        // 
        // PageFooter
        // 
        this.PageFooter.Height = 30;
        this.PageFooter.Name = "PageFooter";
        this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // dataSet11
        // 
        this.dataSet11.DataSetName = "DataSet1";
        this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // categoriesTableAdapter1
        // 
        this.categoriesTableAdapter1.ClearBeforeFill = true;
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
        this.DataAdapter = this.categoriesTableAdapter1;
        this.DataMember = "Categories";
        this.DataSource = this.dataSet11;
        this.Version = "8.2";
        this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReport1_BeforePrint);
        ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //DataSet1TableAdapters.CategoriesTableAdapter da = new DataSet1TableAdapters.CategoriesTableAdapter();
        //DataSet1 ds = new DataSet1();

        //da.Fill(ds.Categories);

        //DataSource = ds.Categories;

        //xrLabel2.Text = "[CategoryName]";
        //xrLabel3.Text = "[Description]";
        //xrPictureBox1.DataBindings.Add("Image", null, "Picture");
    }
}
