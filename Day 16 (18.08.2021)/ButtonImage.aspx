<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonImage.aspx.cs" Inherits="Day18.ButtonImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Click any one of the image to display at bottom"></asp:Label>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/bs-01.jpg" Height="241px" OnClick="ImageButton1_Click" Width="371px" />
              &nbsp;
              <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/image2.jpeg" Height="215px" OnClick="ImageButton2_Click" />
              &nbsp;
              <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/images.jpeg" Width="261px" OnClick="ImageButton3_Click" />
        </div>
        <br /> <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Click on the bottom image to clear It"></asp:Label> <br /><br />
            <asp:ImageButton ID="ImageButton4" runat="server" OnClick="ImageButton4_Click" />
        </div>
    </form>
</body>
</html>
