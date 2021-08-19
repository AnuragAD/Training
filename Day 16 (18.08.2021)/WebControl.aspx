<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControl.aspx.cs" Inherits="Day18.WebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ast .Net</title>
    <style>
        .button{
            background-color:greenyellow;
            
        }
        .button:hover{
            background-color:yellow;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center><h2>Web Controls</h2></center>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hello"></asp:Label>
            <br />
            <br />
            <center>
                <asp:Button ID="Button1" class="button" runat="server" Text="Click Me" OnClick="Button1_Click" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </center>        
                <br />
                <br />      
            <asp:CheckBox ID="CheckBox2" runat="server" />
            <br />
            <br />            
        </div>
    </form>
</body>
</html>
