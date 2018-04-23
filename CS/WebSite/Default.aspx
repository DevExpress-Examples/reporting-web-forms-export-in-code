<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
        <asp:Label ID="Label1" runat="server" Text="Select export type:"></asp:Label>
        <p/>
        <asp:DropDownList ID="ddlExportType" runat="server" Width="60px">
            <asp:ListItem>xls</asp:ListItem>
            <asp:ListItem>pdf</asp:ListItem>
            <asp:ListItem>rtf</asp:ListItem>
            <asp:ListItem>csv</asp:ListItem>
        </asp:DropDownList>
        <p/>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Inline" />
        <p/>
        <asp:Button ID="Button1" runat="server" Text="Export" Width="60px" OnClick="Button1_Click" /></div> <%--PostBackUrl="~/ReportOutput.aspx"--%>
    </form>
</body>
</html>
