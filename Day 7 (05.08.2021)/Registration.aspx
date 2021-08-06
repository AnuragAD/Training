<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Day7.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>


    <title>User Registration </title>
</head>
<body>
        <div class="container">
             <center> <h1> Registration Form</h1> </center> 
        <div class="card">
            <div class="card-body">
          <form id="form1" runat="server">
                      <div class="form-control">
                      <div class="form-group">
                         <asp:Label ID="Label1" runat="server" Text="Label">First Name</asp:Label> 
                          <asp:TextBox ID="TextBox1" runat="server" required="true"></asp:TextBox>
                      </div> <br />
                      <div class="form-group">
                         <asp:Label ID="Label2" runat="server" Text="Label" required="true">Last Name</asp:Label> 
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                      </div>
                          <br />
                      <div class="form-group">
                         <asp:Label ID="Label3" runat="server" Text="Label">Gender</asp:Label> 
                          <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                              <asp:ListItem Value="1">Male</asp:ListItem>
                              <asp:ListItem Value="2">Female</asp:ListItem>
                          </asp:RadioButtonList>
                      </div><br />
                    <div class="form-group">
                         <asp:Label ID="Label4" runat="server" Text="Label" required="true">Age</asp:Label> 
                          <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                      </div><br />
                    <div class="form-group">
                         <asp:Label ID="Label5" runat="server" Text="Label" required="true">State</asp:Label> 
                        <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>Andaman and Nicobar Islands</asp:ListItem>
                                <asp:ListItem>Andhra Pradesh</asp:ListItem>
                                <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                                <asp:ListItem>Himachal Pradesh</asp:ListItem>
                                <asp:ListItem>Madhya Pradesh</asp:ListItem>
                                <asp:ListItem>Maharashtra</asp:ListItem>
                                <asp:ListItem>Manipur</asp:ListItem>
                                <asp:ListItem>Meghalaya</asp:ListItem>
                                <asp:ListItem>Mizoram</asp:ListItem>
                                <asp:ListItem>Nagaland</asp:ListItem>
                                <asp:ListItem>Orissa</asp:ListItem>
                                <asp:ListItem>Punjab</asp:ListItem>
                                <asp:ListItem>Rajasthan</asp:ListItem>
                                <asp:ListItem>Sikkim</asp:ListItem>
                        </asp:DropDownList>
                      </div><br />
                      <div class="form-group">
                          <asp:Button ID="Button1" runat="server" Text="Populate cities" OnClick="Button1_Click" />
                      </div><br />
                          <div class="form-group">
                              <asp:ListBox ID="ListBox1" runat="server" Width="400px"></asp:ListBox>
                      </div><br />
                          <div class="form-group">
                          <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
                      </div><br />
                          <div class="form-group">
                             <asp:ListBox ID="ListBox2" runat="server" Width="400px"></asp:ListBox>
                      </div>
                   </div>
    </form>
       </div>  
      </div>
   
    </div>
</body>
</html>
