using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;

namespace QN12
{
    public partial class QN12 : System.Web.UI.Page
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
                    GridViewBeforeUpdate.DataSource = dataTable;
                    GridViewBeforeUpdate.DataBind();
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedID = txtBookID.Text;

            string bookID = txtNewID.Text;
            string title = txtTitle.Text;
            string publisher = txtPublisher.Text;
            string author = txtAuthor.Text;
            string edition = txtEdition.Text;
            string pages = txtPages.Text;
            string price = txtPrice.Text;
            string publishDate = txtPublishDate.Text;
            string isbn = txtISBN.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(selectedID))
            {
                error++;
                errBookID.InnerHtml = "**Enter the book ID first.";
            }
            if (string.IsNullOrWhiteSpace(bookID))
            {
                error++;
                errNewID.InnerHtml = "**Enter the new book ID.";
            }
            if (string.IsNullOrWhiteSpace(title))
            {
                error++;
                errTitle.InnerHtml = "**Enter the new book title.";
            }
            if (string.IsNullOrWhiteSpace(publisher))
            {
                error++;
                errPublisher.InnerHtml = "**Enter the new publisher name.";
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                error++;
                errAuthor.InnerHtml = "**Enter the new author name.";
            }
            if (string.IsNullOrWhiteSpace(edition))
            {
                error++;
                errEdition.InnerHtml = "**Enter the edition.";
            }
            if (string.IsNullOrWhiteSpace(pages))
            {
                error++;
                errPages.InnerHtml = "**Enter the total no of pages.";
            }
            if (string.IsNullOrWhiteSpace(price))
            {
                error++;
                errPrice.InnerHtml = "**Enter the price of book.";
            }
            if (string.IsNullOrWhiteSpace(publishDate))
            {
                error++;
                errPublishDate.InnerHtml = "**Choice the publish date of book.";
            }
            if (string.IsNullOrWhiteSpace(isbn))
            {
                error++;
                errISBN.InnerHtml = "**Enter ISBN of the book.";
            }
            if (error == 0)
            {
                try
                {
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    // Check if the book with the given ID exists
                    MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM book_data WHERE Book_ID = @bookid", connect);
                    checkCommand.Parameters.AddWithValue("@bookid", selectedID);

                    int bookCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (bookCount > 0)
                    {
                        // Update operation
                        MySqlCommand updateCommand = new MySqlCommand("UPDATE book_data SET Book_ID=@booknewID, Title = @title, Publisher = @publisher, Author = @author, Edition = @edition, Toatl_Pages = @pages, Price = @price, Publish_Date = @publishdate, ISBN = @isbn WHERE Book_ID = @bookid", connect);
                        updateCommand.Parameters.AddWithValue("@bookid", selectedID);
                        updateCommand.Parameters.AddWithValue("@booknewID", bookID);
                        updateCommand.Parameters.AddWithValue("@title", title);
                        updateCommand.Parameters.AddWithValue("@publisher", publisher);
                        updateCommand.Parameters.AddWithValue("@author", author);
                        updateCommand.Parameters.AddWithValue("@edition", edition);
                        updateCommand.Parameters.AddWithValue("@pages", pages);
                        updateCommand.Parameters.AddWithValue("@price", price);
                        updateCommand.Parameters.AddWithValue("@publishdate", publishDate);
                        updateCommand.Parameters.AddWithValue("@isbn", isbn);

                        updateCommand.ExecuteNonQuery();
                        errMessage.InnerText = "Database Connection and Record Updated Successfully";

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
                                GridViewAfterUpdate.DataSource = dataTable1;
                                GridViewAfterUpdate.DataBind();
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
                        errMessage.InnerText = "Error! Book with ID " + selectedID + " does not exist.";
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