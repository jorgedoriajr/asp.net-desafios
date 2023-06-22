using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace QN10
{
    public partial class QN10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResetErrorMessages();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ResetErrorMessages();

            string bookID = txtBookID.Text;
            string title = txtTitle.Text;
            string publisher = txtPublisher.Text;
            string author = txtAuthor.Text;
            string edition = txtEdition.Text;
            string pages = txtPages.Text;
            string price = txtPrice.Text;
            string publishDate = txtPublishDate.Text;
            string isbn = txtISBN.Text;

            int error = 0;

            if (string.IsNullOrWhiteSpace(bookID))
            {
                error++;
                errBookID.InnerHtml = "**Enter the book ID.";
            }
            if(string.IsNullOrWhiteSpace(title))
            {
                error++;
                errTitle.InnerHtml = "**Enter the book title.";
            }
            if(string.IsNullOrWhiteSpace(publisher))
            {
                error++;
                errPublisher.InnerHtml = "**Enter the publisher name.";
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                error++;
                errAuthor.InnerHtml = "**Enter the author name.";
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
            if(string.IsNullOrWhiteSpace(price))
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
                    //Database Connectivety
                    MySqlConnection connect = new MySqlConnection("Server=localhost;Database=project;Uid=root;pwd=;");
                    connect.Open();

                    //Sql Query To Record
                    MySqlCommand command = new MySqlCommand("INSERT INTO book_data (Book_ID, Title, Publisher, Author, Edition, Toatl_Pages, Price, Publish_Date, ISBN)\r\nVALUES (@bookid, @title, @publisher, @author, @edition, @pages, @price, @publishdate, @isbn)", connect);
                    command.Parameters.AddWithValue("@bookid", bookID);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@publisher", publisher);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@edition", edition);
                    command.Parameters.AddWithValue("@pages", pages);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@publishdate", publishDate);
                    command.Parameters.AddWithValue("@isbn", isbn);

                    //execute query
                    command.ExecuteNonQuery();
                    errMessage.InnerText = "Database Connection and Record Stored Successfully";

                }
                catch (Exception ex)
                {
                    errMessage.InnerText = "Error! **" + ex.Message;
                }
            }
        }
        private void ResetErrorMessages()
        {
            errBookID.InnerHtml = String.Empty;
            errTitle.InnerHtml = String.Empty;
            errPublisher.InnerHtml = String.Empty;
            errAuthor.InnerHtml = String.Empty;
            errEdition.InnerHtml = String.Empty;
            errPages.InnerHtml = String.Empty;
            errPrice.InnerHtml = String.Empty;
            errPublishDate.InnerHtml = String.Empty;
            errISBN.InnerHtml = String.Empty;
        }
    }
}