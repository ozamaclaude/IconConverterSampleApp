using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IconConverterApp
{
    public partial class _Default : Page
    {
        private const string _savePath = @"C:\\Users\M.Ozama\forJob\dev\temp\";
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadBtn.Text = "変換";
            if (CheckBox1.Checked)
            {
                UploadBtn.Text = "アップロード";
                Response.Redirect(Request.Url.ToString());
            }
        }
        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            var fPfx = CurrentFileNamePrefix();
            //var pngFileName = fPfx + "_output.png";
            if (FileUpLoad1.HasFile)
            {
                FileUpLoad1.SaveAs(Path.Combine(_savePath, fPfx + FileUpLoad1.FileName));
                Label1.Text = "File Uploaded: " + FileUpLoad1.FileName;
            }
            else
            {
                Label1.Text = "No File Uploaded.";
            }
        }
        private static string CurrentFileNamePrefix()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss_");
        }
    }
}