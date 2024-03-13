using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Hello_world
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string message = messageTextBox.Text;
            HttpPostedFile photoFile = photoFileUpload.PostedFile;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(message))
            {

                Literal nameLiteral = new Literal();
                nameLiteral.Text = "<strong>Name:</strong> " + Server.HtmlEncode(name);


                Literal messageLiteral = new Literal();
                messageLiteral.Text = "<p><strong>Message:</strong> " + Server.HtmlEncode(message) + "</p>";


                entriesPanel.Controls.Add(nameLiteral);
                entriesPanel.Controls.Add(messageLiteral);
            }

            if (photoFile != null && photoFile.ContentLength > 0)
            {
             
                string uploadFolderPath = Server.MapPath("~/Uploads");
              
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(photoFile.FileName);
              
                string filePath = Path.Combine(uploadFolderPath, fileName);

               
                photoFile.SaveAs(filePath);

                
                Literal imgLiteral = new Literal();
                imgLiteral.Text = $"<div style='margin-top: 10px;'><img src='Uploads/{fileName}' style='max-width: 100px; max-height: 100px;'></div>";
                entriesPanel.Controls.Add(imgLiteral);
            }

          
            nameTextBox.Text = "";
            messageTextBox.Text = "";
            photoFileUpload.Attributes.Clear();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}