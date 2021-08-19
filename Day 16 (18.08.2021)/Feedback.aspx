<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Day18.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <div class="container">
        <div class="card" >
             <center><h3>Registration Form</h3></center> 
            <div class="card-body">
               <form id="form1" runat="server">
                <div class="form-control">
                    <div class="form-group">
                        
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Sex"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Select Course"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem >----Select-----</asp:ListItem>
                            <asp:ListItem Value="1">DotNet</asp:ListItem>
                            <asp:ListItem Value="2">Angular</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Technical Coverage"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                            <asp:ListItem Value="1">Excellent</asp:ListItem>
                            <asp:ListItem Value="2">Good</asp:ListItem>
                            <asp:ListItem Value="3">Average</asp:ListItem>
                            <asp:ListItem Value="4">Poor</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Suggestion"></asp:Label><br />
                        <asp:TextBox ID="TextBox2" runat="server" Height="114px" Width="518px"></asp:TextBox>
                    </div>
                    <br />
                    <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Text="Submit Form" OnClick="Button1_Click" />
                </div>
              </form>
            </div>
            <asp:Label ID="Label6" runat="server" ></asp:Label>
            <asp:Label ID="Label7" runat="server"></asp:Label>
        </div>
    </div>
    
</body>
</html>
