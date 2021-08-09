<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoldSilver.aspx.cs" Inherits="Day_9.GoldSilver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class ="container">
        <div class="card">
            <div class="card-body">
                <form id="form1" runat="server">
                    <asp:Label ID="Label1" runat="server"> Prices for </asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem >----Select-----</asp:ListItem>
                    <asp:ListItem Value="1">Gold</asp:ListItem>
                    <asp:ListItem Value="2">Silver</asp:ListItem>
                    <asp:ListItem Value="3">Diamond</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ListBox ID="ListBox1" runat="server">
                          <asp:ListItem>24 Caret 50000</asp:ListItem>
                          <asp:ListItem >23 Caret 30000</asp:ListItem>
                    </asp:ListBox>
                    <asp:ListBox ID="ListBox2" runat="server">
                          <asp:ListItem >Silver 25000</asp:ListItem>
                    </asp:ListBox>
                    <asp:ListBox ID="ListBox3" runat="server">
                          <asp:ListItem >Diamond 80000</asp:ListItem>  
                    </asp:ListBox>
                    <br />
                    <br />
                    <asp:Button Class="btn btn-primary" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </form>
            </div>
    </div>
    </div>
</body>
</html>
