using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace QN13
{
    public partial class QN13 : System.Web.UI.Page
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
                    GridViewBeforeDelete.DataSource = dataTable;
                    GridViewBeforeDelete.DataBind();
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedID = txtBookID.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(selectedID))
            {
                error++;
                errBookID.InnerHtml = "**Enter the book ID first.";
            }
            if (error == 0)
            {
                try
                {
                    // Database Connectivity
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    // SQL Query to remove record
                    MySqlCommand command = new MySqlCommand("DELETE FROM book_data WHERE Book_ID = @bookid", connect);
                    command.Parameters.AddWithValue("@bookid", selectedID);

                    // Execute query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        errMessage.InnerText = "Book removed successfully.";

                        try
                        {
                            MySqlConnection connect1 = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                            connect1.Open();

                            // SQL Query to retrieve all books
                            MySqlCommand command1 = new MySqlCommand("SELECT * FROM book_data", connect1);
                            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                            DataTable dataTable1 = new DataTable();
                            adapter1.Fill(dataTable1);

                            // Display the data in GridView (you can use other controls based on your requirements)
                            if (dataTable1.Rows.Count > 0)
                            {
                                GridViewAfterDelete.DataSource = dataTable1;
                                GridViewAfterDelete.DataBind();
                            }
                            else
                            {
                                errMessage.InnerText = "Error!";
                            }
                        }
                        catch (Exception ex)
                        {
                            errMessage.InnerText = "Error retrieving books! **" + ex.Message;
                        }
                    }
                    else
                    {
                        errMessage.InnerText = "Book with the specified ID not found.";
                    }
                }
                catch (Exception ex)
                {
                    errMessage.InnerText = "Error! **" + ex.Message;
                }
            }
        }
    }
}