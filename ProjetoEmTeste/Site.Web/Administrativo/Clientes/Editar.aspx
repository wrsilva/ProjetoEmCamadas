﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativo/Adm.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Site.Web.Administrativo.Clientes.Editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div id="main" class="container-fluid">
        <h3 class="page-header">Atualizar Informações do Cliente
            <asp:Label ID="lbnNome" runat="server" Text="Label"></asp:Label></h3>

        <!-- area de campos do form -->

        <div class="row">
         
            <div class="form-group col-md-4">
                <label for="Nome">Nome</label>
                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control small"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <label for="Email">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control small"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <label for="Senha">Senha</label>
                <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control small"></asp:TextBox>
            </div>
        </div>


        <hr />
        <div id="actions" class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSalvar" runat="server" Text="Atualizar" CssClass="btn btn-warning" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnVoltar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnVoltar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
