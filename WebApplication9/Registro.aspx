<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="thesisManagementPanel.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="login">
                <nav class="navbar navbar-dark bg-dark">
                   <div>
                        <asp:Button ID="Button3" BackColor="LightGray" Text="Home" class="btn btn-info btn-md" runat="server" />
                        <asp:Button ID="Button4" BackColor="LightGray" Text="Login" class="btn btn-info btn-md" runat="server" />
                       <asp:Button ID="Button5" BackColor="LightGray" Text="Contato" class="btn btn-info btn-md"  runat="server" />
                       <asp:Button ID="Button6" BackColor="LightGray" Text="Sobre" class="btn btn-info btn-md" runat="server" />
                    </div>
                </nav>
                <div class="container">
                    <div id="login-row" class="row justify-content-center align-items-center">
                        <div id="login-column" class="col-md-6">
                            <div id="login-box" class="col-md-12">
                                <div id="login-form" class="form">
                                    <h3 class="text-center text-info">Registro de Ouvintes</h3>
                                    <div class="form-group">
                                        <label for="username" class="text-info">Nome:</label><br>
                                        <input type="text" runat="server" name="nome" id="nome" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="username" class="text-info">Usuário:</label><br>
                                        <input type="text" runat="server" name="username" id="username" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="password" class="text-info">Senha:</label><br>
                                        <input type="password" runat="server" name="password" id="password" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="username" class="text-info">Email:</label><br>
                                        <input type="text" runat="server" name="email" id="email" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="username" class="text-info">Celular:</label><br>
                                        <input type="text" runat="server" name="celular" id="celular" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="username" class="text-info">CPF:</label><br>
                                        <input type="text" runat="server" name="cpf" id="cpf" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" class="btn btn-info btn-md" />
                                        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" class="btn btn-info btn-md" BackColor="Red" />
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
