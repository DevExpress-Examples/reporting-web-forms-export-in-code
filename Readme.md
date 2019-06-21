<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [ReportOutput.aspx](./CS/WebSite/ReportOutput.aspx) (VB: [ReportOutput.aspx](./VB/WebSite/ReportOutput.aspx))
* [ReportOutput.aspx.cs](./CS/WebSite/ReportOutput.aspx.cs) (VB: [ReportOutput.aspx.vb](./VB/WebSite/ReportOutput.aspx.vb))
<!-- default file list end -->
# How to programmatically export a report in an ASP.NET application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1281/)**
<!-- run online end -->


<p>This example demonstrates how to export an XtraReport instance in an ASP.NET application via the Response.BinaryWrite() method. First, in the Default.aspx page, you should select the export file format and specify whether the exported document intended to be displayed "inline" i. e. in the same browser window. Then, click the "Export" button. The report is created and stored in the Session variable. The user is then redirected to the ReportOutput.aspx. The report, persisting in the Session, will be exported to this page base in the settings you've specified on the first page.</p>

<br/>


