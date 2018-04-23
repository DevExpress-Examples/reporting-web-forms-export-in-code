# How to programmatically export a report in an ASP.NET application


<p>This example demonstrates how to export an XtraReport instance in an ASP.NET application via the Response.BinaryWrite() method. First, in the Default.aspx page, you should select the export file format and specify whether the exported document intended to be displayed "inline" i. e. in the same browser window. Then, click the "Export" button. The report is created and stored in the Session variable. The user is then redirected to the ReportOutput.aspx. The report, persisting in the Session, will be exported to this page base in the settings you've specified on the first page.</p>

<br/>


