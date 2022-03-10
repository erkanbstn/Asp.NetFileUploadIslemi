using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUploadAspNet
{
    public partial class DosyaYukle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string uzanti = Path.GetExtension(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath($"Resim/{FileUpload1.FileName}"));
                Label1.Text = "Dosya Yükleme Başarılı.";
            }
            else
            {
                Label1.Text = "Dosya Seçmediniz.";
            }
        }
    }
}