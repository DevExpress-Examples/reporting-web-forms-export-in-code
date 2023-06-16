Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.Text

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As New XtraReport1()

		Session("report") = report
	End Sub

	Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Response.Redirect("~/ReportOutput.aspx?ddlExportType=" & ddlExportType.SelectedValue & "&bInline=" & CheckBox1.Checked)
	End Sub
End Class