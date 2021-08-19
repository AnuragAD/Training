<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Advertisement.aspx.cs" Inherits="Day18.Advertisement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>
            <asp:LinkButton ID="LinkButton1" runat="server" BorderWidth="5px" Font-Size="Small" Height="80px" Width="60px" OnClick="LinkButton1_Click">Amazon</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" BorderWidth="5px" Font-Size="Small" Height="80px" Width="60px" OnClick="LinkButton2_Click">Fabmart</asp:LinkButton>
            </center>
        </div>
    </form>
</body>
</html>
