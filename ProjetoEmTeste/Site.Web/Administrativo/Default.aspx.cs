using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web.Administrativo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
        protected void ButtonEditar_Click(object sender, EventArgs e)
        {

            Button btn = (sender as Button);

            int id = int.Parse(gridClientes.DataKeys[(btn.NamingContainer as GridViewRow).RowIndex]["Codigo"].ToString());
            Session["Codigo"] = id;
            string nome = Request.Params["Nome"];
  


        }

        protected void gridClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridClientes.PageIndex = e.NewPageIndex;
            DBContexto db = new DBContexto();
            gridClientes.DataSource = db.Listar(); // Popular a grid
            gridClientes.DataBind(); // Exibir conteudo da Grid
        }


      

    }
}