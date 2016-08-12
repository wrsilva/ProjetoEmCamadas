<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Web.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css' />

    <link rel="stylesheet" href="css/normalize.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <link rel="stylesheet" href="css/style_login.css" />


    <div class="container text-center">
        <div class="row">
            <div class="contact-caption clearfix">

                <asp:HyperLink ID="LinkCadastro" NavigateUrl="~/Cadastro.aspx" runat="server">Cadastro</asp:HyperLink>

                <div class="col-md-5 contact-info text-right">
                    <div class="text-center">
                        <h3 style="color: #3E4095; position: center;">Login</h3>
                    </div>
                    <br />

                    <div class="field-wrap">
                        <asp:TextBox ID="UserName" required="true" runat="server" AutoCompleteType="Email" placeholder="Email"></asp:TextBox>
                    </div>
                    <div class="field-wrap">
                        <asp:TextBox ID="Password" required="true" type="password" placeholder="Senha" runat="server"></asp:TextBox>
                    </div>


                    <p class="forgot"><a href="#">Esqueceu a senha?</a></p>
                    <asp:Button ID="ButtonLogin" CssClass="button button-block" runat="server" Text="Entrar" OnClick="ButtonEntrar_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Cadastro.aspx" CssClass="button alert-danger">Cadastre-se</asp:HyperLink>


                </div>
            </div>
        </div>
    </div>











</asp:Content>
