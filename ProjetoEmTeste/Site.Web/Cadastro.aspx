<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Web.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <br />
    <link rel="stylesheet" href="css/style_login.css" />
    <div class="container">
        <div class="row">
            <div class="contact-caption clearfix">
                <!--CADASTRO-->
                <div class="col-md-5 contact-info text-center">
                    <div class="text-center">
                        <h3 style="color: #3E4095; position: center;">Cadastro</h3>
                    </div>
                    <br />
                    <div class="top-row">
                        <div class="field-wrap">
                            <asp:TextBox ID="TextBoxNome" required="true" class="name" type="text" placeholder="Name" AutoCompleteType="FirstName" runat="server"></asp:TextBox>
                        </div>
                        <div class="field-wrap">
                            <asp:TextBox ID="TextBoxSobreNome" required="true" class="name" type="text" placeholder="Sobre Nome" AutoCompleteType="LastName" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="field-wrap">
                        <asp:TextBox ID="TextBoxEmail" required="true" runat="server" AutoCompleteType="Email" placeholder="Email"></asp:TextBox>
                    </div>
                    <div class="field-wrap">
                        <asp:TextBox ID="TextBoxSenha" required="true" type="password" placeholder="Senha" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonSalvar" CssClass="button button-block" runat="server" Text="Cadastrar" OnClick="ButtonSalvar_Click" />

                </div>
            </div>
        </div>
    </div>





</asp:Content>
