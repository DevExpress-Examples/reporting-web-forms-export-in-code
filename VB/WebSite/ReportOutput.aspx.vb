Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports DevExpress.XtraReports.UI

Partial Public Class ReportOutput
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As XtraReport = TryCast(Session("report"), XtraReport)

		If report IsNot Nothing Then
			ExportReport(report, "report", Request.QueryString("ddlExportType"), Convert.ToBoolean(Request.QueryString("bInline")))
		Else
			Label1.Visible = True
		End If
	End Sub

	Public Sub ExportReport(ByVal report As XtraReport, ByVal fileName As String, ByVal fileType As String, ByVal inline As Boolean)
		Dim stream As New MemoryStream()

		Response.Clear()

		If fileType = "xls" Then
			report.ExportToXls(stream)
		End If
		If fileType = "pdf" Then
			report.ExportToPdf(stream)
		End If
		If fileType = "rtf" Then
			report.ExportToRtf(stream)
		End If
		If fileType = "csv" Then
			report.ExportToCsv(stream)
		End If

		Response.ContentType = "application/" & fileType
		Response.AddHeader("Accept-Header", stream.Length.ToString())
		If inline Then
			Response.AddHeader("Content-Disposition", ("Inline") & "; filename=" & fileName & "." & fileType)
		Else
			Response.AddHeader("Content-Disposition", ("Attachment") & "; filename=" & fileName & "." & fileType)
		End If
		Response.AddHeader("Content-Length", stream.Length.ToString())
		'Response.ContentEncoding = System.Text.Encoding.Default;
		Response.BinaryWrite(stream.ToArray())
		Response.End()
	End Sub

End Class
