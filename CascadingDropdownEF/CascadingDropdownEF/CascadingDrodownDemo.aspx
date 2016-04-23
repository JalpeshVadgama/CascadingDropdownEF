<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CascadingDrodownDemo.aspx.cs" Inherits="CascadingDropdownEF.CascadingDrodownDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cascading dropwon demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList runat="server" ID="ddlStandard"/>
    </div>
        <div>
            <asp:DropDownList runat="server" ID="ddlStudent"/>
        </div>
    </form>
</body>
</html>
