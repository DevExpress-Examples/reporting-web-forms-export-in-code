using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using DevExpress.XtraReports.UI;

public partial class ReportOutput : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        XtraReport report = Session["report"] as XtraReport;

        if (report != null)
            ExportReport(report, "report", Request.QueryString["ddlExportType"], Convert.ToBoolean(Request.QueryString["bInline"]));
        else
            Label1.Visible = true;
    }

    public void ExportReport(XtraReport report, string fileName, string fileType, bool inline) {
        MemoryStream stream = new MemoryStream();
        
        Response.Clear();
        
        if(fileType == "xls")
            report.ExportToXls(stream);
        if(fileType == "pdf")
            report.ExportToPdf(stream);
        if(fileType == "rtf")
            report.ExportToRtf(stream);
        if(fileType == "csv")
            report.ExportToCsv(stream);

        Response.ContentType = "application/" + fileType;
        Response.AddHeader("Accept-Header", stream.Length.ToString());
        Response.AddHeader("Content-Disposition", (inline ? "Inline" : "Attachment") + "; filename=" + fileName + "." + fileType);
        Response.AddHeader("Content-Length", stream.Length.ToString());
        //Response.ContentEncoding = System.Text.Encoding.Default;
        Response.BinaryWrite(stream.ToArray());
        Response.End();
    }

}
