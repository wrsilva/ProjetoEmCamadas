<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativo/Adm.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Web.Administrativo.Clientes.Detalhes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="main" class="container-fluid">
        <h3 class="page-header">Detalhes do Cliente</h3>

        <!-- area de campos do form -->

        <div class="row">
         
            <div class="form-group col-md-4">
                <label for="Nome">Nome:</label>
                <asp:Label runat="server" ID="lbnNome" CssClass=""></asp:Label>
            </div>

            <div class="form-group col-md-4">
                <label for="Email">Email:</label>
                <asp:Label runat="server" ID="lbnEmail" CssClass=""></asp:Label>
            </div>

            <div class="form-group col-md-4">
                <label for="Senha">Senha:</label>
                <asp:Label runat="server" ID="lbnSenha" CssClass=""></asp:Label>
            </div>
        </div>


        <hr />
        <div id="actions" class="row">
            <div class="col-md-12">
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="btn btn-default" OnClick="btnVoltar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
