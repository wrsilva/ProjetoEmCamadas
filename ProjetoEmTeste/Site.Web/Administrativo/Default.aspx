<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Administrativo/Adm.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Web.Administrativo.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Clientes Cadastrados</h1>
    <br />
    <div class="form-inline">
        <div class="form-group">
            <div class="form-group form-group-lg">
                <div class="col-sm-10">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control small"></asp:TextBox>
                </div>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-group-lg btn-primary" Text="Pesquisar" />
        <asp:Button ID="Button2" runat="server" CssClass="btn btn-group-lg btn-success" Text="Cadastrar Novo" />
    </div>
    <br />
    <br />


    <asp:GridView ID="gridClientes" runat="server" AllowPaging="true" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover" GridLines="None" DataKeyNames="Codigo" OnSelectedIndexChanged="gridClientes_SelectedIndexChanged" OnPageIndexChanging="gridClientes_PageIndexChanging">

        <Columns>

            <asp:TemplateField HeaderText="Nome">
                <ItemTemplate><%#Eval("Nome") %>    </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                <ItemTemplate><%#Eval("Email") %>    </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Senha">
                <ItemTemplate><%#Eval("Senha") %>    </ItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning btn-sm" OnClick="ButtonEditar_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Detalhes">
                <ItemTemplate>
                    <asp:Button ID="btnDetalhes" runat="server" Text="Detalhes" CssClass="btn btn-info btn-sm" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deletar">
                <ItemTemplate>
                    <asp:Button ID="btnDelte" runat="server" Text="Deletar" CssClass="btn btn-danger btn-sm" />
                </ItemTemplate>
            </asp:TemplateField>


        </Columns>


        <%-- Paginação --%>

        <PagerSettings Position="Bottom" Mode="NextPreviousFirstLast"
            PreviousPageText="|Página Anterior|"
            NextPageText="|Próxima Página|"
            FirstPageText="|Primeira Página|"
            LastPageText="|Última Página|"
            PageButtonCount="4" />

        <%--<PagerSettings Position="Bottom" Mode="NextPreviousFirstLast"
            PreviousPageText="<img src='imagens/seta-esquerda.png' border='0' title='Página Anterior'/>"
            NextPageText="<img src='imagens/seta-direita.png' border='0' title='Próxima Página'/>"
            FirstPageText="<img src='imagens/seta-esquerda-ultima.png' border='0' title='Primeira Página'/>"
            LastPageText="<img src='imagens/seta-direita-ultima.png' border='0' title='Última Página'/>" PageButtonCount="15" />--%>
    </asp:GridView>



</asp:Content>
