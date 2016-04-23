<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDrodownDemo.aspx.cs" Inherits="CascadingDropdownEF.CascadingDrodownDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cascading dropwon demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="ddlStandard" CssClass="dropdown" AutoPostBack="true" sele="ddlStandard_OnSelectedIndexChanged"/>
        </div>
        <br/>
        <div>
            <asp:DropDownList runat="server" ID="ddlStudent" CssClass="dropdown"/>
        </div>
    </form>
</body>
</html>
