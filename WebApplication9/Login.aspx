<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="thesisManagementPanel.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                        <asp:Button ID="Button2" BackColor="LightGray" Text="Home" class="btn btn-info btn-md" runat="server" />
                        <asp:Button ID="Button3" Text="Login" class="btn btn-info btn-md" runat="server" />
                       <asp:Button ID="Button4" BackColor="LightGray" Text="Contato" class="btn btn-info btn-md" OnClick="Button4_Click" runat="server" />
                       <asp:Button ID="Button5" BackColor="LightGray" Text="Sobre" class="btn btn-info btn-md" OnClick="Button5_Click" runat="server" />
                    </div>
                </nav>
                <h3 class="text-center text-white pt-5">Painel de Login</h3>
                <div class="container">
                    <div id="login-row" class="row justify-content-center align-items-center">
                        <div id="login-column" class="col-md-6">
                            <div id="login-box" class="col-md-12">
                                <div id="login-form" class="form">
                                    <h3 class="text-center text-info">Login</h3>
                                    <div class="form-group">
                                        <label for="username" class="text-info">Usuário:</label><br>
                                        <input type="text" runat="server" name="username" id="username" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="password" class="text-info">Senha:</label><br>
                                        <input type="password" runat="server" name="password" id="password" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <br>
                                        <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" class="btn btn-info btn-md" />
                                    </div>
                                    <div id="register-link" class="text-right">
                                        <a href="Registro.aspx" class="text-info">Registrar-se</a>
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
