using MySql.Data.MySqlClient;
using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web.Administrativo.Clientes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                    DBContexto db = new DBContexto();
                    gridClientes.DataSource = db.Listar(); // Popular a grid
                    gridClientes.DataBind(); // Exibir conteudo da Grid


                }
                catch (Exception ex)
                {

                    //Label1.Text = ex.ToString();
                }
            }

        }
        //Botao de editar
        protected void ButtonEditar_Click(object sender, EventArgs e)
        {

            Button btn = (sender as Button);

            int id = int.Parse(gridClientes.DataKeys[(btn.NamingContainer as GridViewRow).RowIndex]["Codigo"].ToString());

            Session["CodigoCliente"] = id;

            Response.Redirect("~/Administrativo/Clientes/Editar.aspx");

        }
        //Paginação
        protected void gridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridClientes.PageIndex = e.NewPageIndex;
            DBContexto db = new DBContexto();
            gridClientes.DataSource = db.Listar(); // Popular a grid
            gridClientes.DataBind(); // Exibir conteudo da Grid
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {

            Button btn = (sender as Button);

            int id = int.Parse(gridClientes.DataKeys[(btn.NamingContainer as GridViewRow).RowIndex]["Codigo"].ToString());

            Session["CodigoCliente"] = id;

            Response.Redirect("~/Administrativo/Clientes/Deletar.aspx");

        }
        protected void ButtonDetalhes_Click(object sender, EventArgs e)
        {

            Button btn = (sender as Button);

            int id = int.Parse(gridClientes.DataKeys[(btn.NamingContainer as GridViewRow).RowIndex]["Codigo"].ToString());

            Session["CodigoCliente"] = id;

            Response.Redirect("~/Administrativo/Clientes/Detalhes.aspx");

        }

        protected void ButtonNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrativo/Clientes/Novo.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                DBContexto db = new DBContexto();
                gridClientes.DataSource = db.ListarBusca(txtStringPesquisar.Text); // Popular a grid
                gridClientes.DataBind(); // Exibir conteudo da Grid


            }
            catch (Exception ex)
            {

                //Label1.Text = ex.ToString();
            }

        }
    }
}