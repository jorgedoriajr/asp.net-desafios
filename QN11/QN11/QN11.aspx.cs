using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace QN11
{
    public partial class QN11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                connect.Open();

                // SQL Query to retrieve all books
                MySqlCommand command = new MySqlCommand("SELECT * FROM book_data", connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Display the data in GridView (you can use other controls based on your requirements)
                if (dataTable.Rows.Count > 0)
                {
                    GridView.DataSource = dataTable;
                    GridView.DataBind();
                }
                else
                {
                    errMessage.InnerText = "No data found.";
                }
            }
            catch (Exception ex)
            {
                errMessage.InnerText = "Error retrieving books! **" + ex.Message;
            }
        }
    }
}