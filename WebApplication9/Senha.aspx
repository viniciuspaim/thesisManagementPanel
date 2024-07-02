<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Senha.aspx.cs" Inherits="thesisManagementPanel.Senha" %>

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
                        <asp:Button ID="Button3" Text="Pesquisa" class="btn btn-info btn-md" OnClick="Button3_Click" runat="server" />
                        <asp:Button ID="Button4" BackColor="LightGray" Text="Contato" class="btn btn-info btn-md" OnClick="Button4_Click" runat="server" />
                        <asp:Button ID="Button5" BackColor="LightGray" Text="Sobre" class="btn btn-info btn-md" OnClick="Button5_Click" runat="server" />
                    </div>
                </nav>
                <div class="container">
                    <div id="login-row" class="row justify-content-center align-items-center">
                        <div id="login-column" class="col-md-6">
                            <div id="login-box" class="col-md-12">
                                <div id="login-form" class="form">
                                    <h3 class="text-center text-info">Alteração de Senha</h3>
                                    <div class="form-group">
                                        <label for="password" class="text-info">Senha Atual:</label><br>
                                        <input type="password" runat="server" name="senhaatual" id="senhaatual" class="form-control" />

                                    </div>
                                    <div class="form-group">
                                        <label for="password" class="text-info">Nova Senha:</label><br>
                                        <input type="password" runat="server" name="novasenha" id="novasenha" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <label for="password" class="text-info">Repetir Senha:</label><br>
                                        <input type="password" runat="server" name="novasenha1" id="novasenha1" class="form-control" />
                                    </div>
                                    <div class="form-group">
                                        <br>
                                        <asp:Button ID="Button1" runat="server" Text="Alterar" OnClick="Button1_Click" class="btn btn-info btn-md" />
                                        <asp:Button ID="Button2" runat="server" BackColor="Red" Text="Cancelar" OnClick="Button2_Click" class="btn btn-info btn-md" />
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
