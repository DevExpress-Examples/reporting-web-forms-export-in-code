﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        XtraReport1 report = new XtraReport1();

        Session["report"] = report;
    }

    protected void Button1_Click(object sender, EventArgs e) {
        Response.Redirect("~/ReportOutput.aspx?ddlExportType=" + ddlExportType.SelectedValue + "&bInline=" + CheckBox1.Checked);
    }
}