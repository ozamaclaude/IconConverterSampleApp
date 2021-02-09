using System;
using System.Collections.Generic;
using System.Drawing;
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
            var pngPath = Path.Combine(_savePath, fPfx + FileUpLoad1.FileName);
            if (FileUpLoad1.HasFile)
            {
                FileUpLoad1.SaveAs(Path.Combine(_savePath, fPfx + FileUpLoad1.FileName));
                Label1.Text = "File Uploaded: " + FileUpLoad1.FileName;
            }
            else
            {
                Label1.Text = "No File Uploaded.";
            }

            // ここでは、Iconファイルに変換するルートとする
            if(CheckBox1.Checked)
            {
                var icoFilePath = Path.Combine(_savePath, fPfx + ".ico");
                using (FileStream stream = File.OpenWrite(icoFilePath))
                {
                    Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(pngPath);
                    Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                }
            }

        }
        private static string CurrentFileNamePrefix()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss_");
        }
    }
}