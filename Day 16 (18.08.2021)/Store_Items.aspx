<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store_Items.aspx.cs" Inherits="Day18.Store_Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js" integrity="sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js" integrity="sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script>
    <title></title>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    </head>
<body>
    <div class="container">
        <div class="card" >
             <center><h3>General Store Demo</h3></center> 
            <div class="card-body">
               <form id="form1" runat="server">
                <div class="form-control">
                  <div class="row">
                      <div class="col-md-6">
                    <div class="form-group">
                        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="208px" Width="172px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                           <asp:ListItem Value="./Images/Soap.jpeg" >Soap</asp:ListItem>
                            <asp:ListItem Value="./Images/Biscuit.jpeg">Biscuit</asp:ListItem>
                            <asp:ListItem Value="./Images/Salt.jpeg" >Salt</asp:ListItem>
                            <asp:ListItem Value="./Images/Oil.jpeg">Cooking Oil</asp:ListItem>
                            <asp:ListItem Value="./Images/Shampoo.jfif">Shampoo</asp:ListItem>
                            <asp:ListItem Value="./Images/Chocolate.jfif">Chocolates</asp:ListItem>
                        </asp:ListBox>
                    </div>
                    </div>
                    <div class="col-md-6">
                    <asp:Image ID="Image1" runat="server" />
                        </div>
                  </div>
                    <div class="form-group">
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="View Price" OnClick="Button1_Click"/>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Cost Per Unit: ₹"></asp:Label>
                        &nbsp;
                        <asp:TextBox id="TextBox1" runat="server" ReadOnly="true" Width="69px" CssClass="offset-sm-0"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Enter Total Unit"></asp:Label>
                        &nbsp;&nbsp;
                     <asp:TextBox id="TextBox2" runat="server"></asp:TextBox>   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="Total Cost: ₹"></asp:Label>
                        &nbsp;<asp:TextBox id="TextBox3" runat="server" ReadOnly="true" CssClass="offset-sm-0"></asp:TextBox>
                    </div>
                    </div>
              </form>
            </div>
        </div>
    </div>
    <script>
        $(document).on("change keyup blur", "#TextBox2", function () {
            var cost = parseInt($("#TextBox1").val(), 10);
            var unit = parseInt($("#TextBox2").val(), 10);
            var total = cost*unit;
            $('#TextBox3').val(total);
        });
    </script>
</body>
</html>
