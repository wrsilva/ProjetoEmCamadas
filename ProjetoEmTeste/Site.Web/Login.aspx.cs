using MySql.Data.MySqlClient;
using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site.Model;

namespace Site.Web
{
    public partial class Login1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {


        }

        protected void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Uid=root; Pwd=1234; Database=ntur;";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            string selectString = "SELECT Count(Email) FROM Cliente WHERE Email = '" + UserName.Text + "' AND Senha = '" + Password.Text + "'";

            MySqlCommand mySqlCommand = new MySqlCommand(selectString, mySqlConnection);
            mySqlConnection.Open();

            String strResult = String.Empty;
            int a = Convert.ToInt32(mySqlCommand.ExecuteScalar().ToString());

            mySqlConnection.Close();

            if (a == 0)
            {
                //User Not Exists
                Response.Write("Nao Existe");
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Session["Email"] = UserName.Text;
                Session["Senha"] = Password.Text;
                Response.Redirect("~/Administrativo/Default.aspx");
             
                //Response.Write(@"<script language='javascript'>alert('Existe esse email \n .)'");

            }
        }

    }



}
