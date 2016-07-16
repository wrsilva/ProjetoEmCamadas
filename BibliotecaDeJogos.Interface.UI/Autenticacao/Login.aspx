<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaDeJogos.Interface.UI.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <div class="container">
            <div class="row">
                <div class="col-md-offset-5 col-md-3">

                    <div class="form-login">
                        <h4>Login</h4>
                        <div>
                            Email:
                        </div>
                        <div>
                            <asp:TextBox runat="server" class="form-control input-sm chat-input" ID="txtLogin" placeholder="Email" ></asp:TextBox><br />
                        </div>
                        <div>Senha: </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtSenha" class="form-control input-sm chat-input" TextMode="Password" placeholder="Senha"></asp:TextBox><br />
                        </div>
                        <asp:Label runat="server" ID="lbnStatus"  ForeColor="Red"></asp:Label>
                        <div class="wrapper">
                            <span class="group-btn">
                                <asp:Button runat="server" class="btn btn-primary btn-md" Text="Entrar" OnClick="btn_Entrar" /><i class="fa fa-sign-in"></i>
                            </span>
                        </div>
                    </div>

                </div>
            </div>
        </div>



    </form>
</body>
</html>
