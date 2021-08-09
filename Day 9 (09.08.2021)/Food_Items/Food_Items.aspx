﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Food_Items.aspx.cs" Inherits="Day_9.Food_Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <div class ="container">
        <div class="card">
            <div class="card-body">
                <form id="form1" runat="server">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem >----Select Food Item-----</asp:ListItem>
                    <asp:ListItem Value="1">BreakFast</asp:ListItem>
                    <asp:ListItem Value="2">Lunch</asp:ListItem>
                    <asp:ListItem Value="3">Snacks</asp:ListItem>
                </asp:DropDownList><br />
                    <asp:Button Class="btn btn-primary" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                </form>
            </div>
    </div>
    </div>
</body>
</html>
