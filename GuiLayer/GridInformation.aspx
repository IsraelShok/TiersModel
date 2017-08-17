<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridInformation.aspx.cs" Inherits="GuiLayer.GridInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID ="btnGetInformation" runat ="server" OnClick="btnGetInformation_Click" Text="Get Stores"/>
    <asp:GridView ID="grdInformation" runat ="server" />

    </div>
    </form>
</body>
</html>
