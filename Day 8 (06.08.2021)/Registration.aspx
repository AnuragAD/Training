<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Day_8.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 103px;
        }
    </style>
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
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox1" runat="server" required="true"></asp:TextBox>
                      </div> <br />
                      <div class="form-group">
                         <asp:Label ID="Label2" runat="server" Text="Label" required="true">Last Name</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                      </div>
                          <br />
                      <div class ="row">
                          <div class="col-md-6">
                                    <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Label">Gender</asp:Label> 
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                        <asp:ListItem Value="1">Male</asp:ListItem>
                                        <asp:ListItem Value="2">Female</asp:ListItem>
                                    </asp:RadioButtonList>
                      </div>
                          </div>
                          <div class="col-md-6">
                              <div class="form-group">
                              <asp:Label ID="Label6" runat="server" Text="Label">Marital Status</asp:Label> 
                              <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                              <asp:ListItem Value="1">Single</asp:ListItem>
                              <asp:ListItem Value="2">Married</asp:ListItem>
                              <asp:ListItem Value="3">Divorced</asp:ListItem>
                              </asp:RadioButtonList>
                      </div>
                          </div>
                      </div>
                    <div class="form-group">
                         <asp:Label ID="Label4" runat="server" Text="Label" required="true">Age</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                      </div><br />
                    <div class="form-group">
                         <asp:Label ID="Label5" runat="server" Text="Label" required="true">Email Id</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
                      </div><br /> 
                <div class="form-group">
                         <asp:Label ID="Label7" runat="server" Text="Label" required="true">Pincode</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox5" runat="server" TextMode="Number" MaxLength="6" MinLength="6" ></asp:TextBox>
                      </div><br /> 
                <div class="form-group">
                         <asp:Label ID="Label8" runat="server" Text="Label" required="true">Password</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
                </div><br /> 
                <div class="form-group">
                         <asp:Label ID="Label9" runat="server" Text="Label" required="true">Confirm Password</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
                </div><br /> 
                <div class="form-group">
                         <asp:Label ID="Label10" runat="server"  required="true">Occupation</asp:Label> 
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                          <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="auto-style1" Width="277px">
                              <asp:ListItem Value="1">Software Engineer</asp:ListItem>
                              <asp:ListItem Value="2">Manager</asp:ListItem>
                              <asp:ListItem Value="3">Lawyer</asp:ListItem>
                              <asp:ListItem Value="4">Teacher</asp:ListItem>
                          </asp:CheckBoxList>
                </div><br /> 
                <div class="form-group">
                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </div>
    </form>
       </div>  
      </div>
   
    </div>
</body>
</html>
