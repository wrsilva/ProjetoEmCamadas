<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativo/Adm.Master" AutoEventWireup="true" CodeBehind="Deletar.aspx.cs" Inherits="Site.Web.Administrativo.Clientes.Deletar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="main" class="container-fluid">
        <h3 class="page-header">Certeza que deseja deletar o Cliente?</h3>

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
                <asp:Button ID="btnSalvar" runat="server" Text="Deletar" CssClass="btn btn-danger" OnClick="btnDeletar_Click"  />
                <asp:Button ID="btnVoltar" runat="server" Text="Cancelar" CssClass="btn btn-default" OnClick="btnVoltar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
