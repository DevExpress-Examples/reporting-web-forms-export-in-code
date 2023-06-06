<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602652/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1281)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for Web Forms -  Export a Report in Code

This example usses the Response.BinaryWrite method to export an XtraReport instance in an ASP.NET application.

Select the export file format and specify whether the exported document should be displayed in the same browser window (inline). Click the "Export" button. The report is created and stored in the `Session` variable. The user is redirected to the `ReportOutput.aspx` page. The report is obtained from `Session` and exported to the specified format.

![](Images/screenshot.png)

## Files to Review

* [XtraReport1.cs](./CS/WebSiteExportTest/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSiteExportTest/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSiteExportTest/Default.aspx) (VB: [Default.aspx](./VB/WebSiteExportTest/Default.aspx))
* [Default.aspx.cs](./CS/WebSiteExportTest/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSiteExportTest/Default.aspx.vb))
* [ReportOutput.aspx](./CS/WebSiteExportTest/ReportOutput.aspx) (VB: [ReportOutput.aspx](./VB/WebSiteExportTest/ReportOutput.aspx))
* [ReportOutput.aspx.cs](./CS/WebSiteExportTest/ReportOutput.aspx.cs) (VB: [ReportOutput.aspx.vb](./VB/WebSiteExportTest/ReportOutput.aspx.vb))

## Documentation

- [Print and Export Reports without a Preview in ASP.NET Web Forms Applications](https://docs.devexpress.com/XtraReports/401846/web-reporting/asp-net-webforms-reporting/print-and-export-reports-without-preview-in-asp-net-web-forms-applications)
- [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports)

## More Examples

- [Reporting for ASP.NET WebForms - How to print or export a report without showing a preview](https://github.com/DevExpress-Examples/reporting-webforms-print-export-report-without-showing-a-preview)
