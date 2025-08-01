﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admins.aspx.cs" Inherits="thesisManagementPanel.Admins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="login">
                <nav class="navbar navbar-dark bg-dark">
                   <div>
                        <asp:Button ID="Button3" BackColor="LightGray" Text="Home" class="btn btn-info btn-md"  runat="server" />
                        <asp:Button ID="Button4" BackColor="LightGray" Text="Pesquisa" class="btn btn-info btn-md"  runat="server" />
                       <asp:Button ID="Button5" BackColor="LightGray" Text="Principal" class="btn btn-info btn-md"  runat="server" />
                       <asp:Button ID="Button6" BackColor="LightGray" Text="Admin" class="btn btn-info btn-md"  runat="server" />
                       <asp:Button ID="Button7" BackColor="LightGray" Text="Senha" class="btn btn-info btn-md" OnClick="Button7_Click"  runat="server" />
                   <asp:Button ID="Button8" BackColor="LightGray" Text="Sair" class="btn btn-info btn-md" OnClick="Button8_Click" runat="server" /> 
                   </div>
                </nav>
                <div class="container">
                    <div id="login-row" class="row justify-content-center align-items-center">
                        <div id="login-column" class="col-md-6">
                            <div id="login-box" class="col-md-12">
                                <div id="login-form" class="form">
                                    <h3 class="text-center text-info">Cadastro de Admin</h3>
                                    <div class="form-group">
                                        <label for="nome" class="text-info">Nome:</label><br />
                                        <asp:DropDownList ID="DropDownList1" runat="server" Class="form-control">
                                            <asp:ListItem Value="0"> Preenchimento Obrigatório</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="form-group">
                                        <br />
                                        <asp:Button ID="Button1" runat="server" Text="Salvar"  OnClick="Button1_Click"  class="btn btn-info btn-md" />                                        
                                        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" class="btn btn-info btn-md" BackColor="Red" />                                        
                                    </div>
                                    <br />
                                    <br />
                                    <div id="register-link" class="text-right">
                                        <a href="RmAdm.aspx" class="text-info">Remover Privilégio de Admin</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
