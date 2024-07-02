<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="thesisManagementPanel.Home" %>

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
                       <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
                        <asp:Button ID="Button3" Text="Home" class="btn btn-info btn-md" runat="server" />
                       <asp:Button ID="Button7" BackColor="LightGray" Text="Cadastro de Gestor" class="btn btn-info btn-md" OnClick="Button7_Click" runat="server" />
                       <asp:Button ID="Button8" BackColor="LightGray" Text="Pesquisa" class="btn btn-info btn-md" OnClick="Button8_Click" runat="server" />
                       <asp:Button ID="Button9" BackColor="LightGray" Text="Principal" class="btn btn-info btn-md" runat="server" />
                       <asp:Button ID="Button10" BackColor="LightGray" Text="Senha" class="btn btn-info btn-md" OnClick="Button10_Click" runat="server" />
                       <asp:Button ID="Button11" BackColor="LightGray" Text="Sair" class="btn btn-info btn-md" OnClick="Button11_Click" runat="server" />
                    </div>
                  </nav>
                <div class="container">
                    <div id="login-row" class="row justify-content-center align-items-center">
                        <div id="login-column" class="col-md-6">
                            <div id="login-box" class="col-md-12">
                                <div id="login-form" class="form">
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
