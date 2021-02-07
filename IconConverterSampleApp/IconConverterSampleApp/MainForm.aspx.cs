using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IconConverterSampleApp
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = Request.Form["postdata"];
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var data = Request.Form["postdata"];

            var data1 = Request.Files["postdata"];

            var aaa = DropDownList1.SelectedItem;

            data1.SaveAs("C:\\Users\\M.Ozama\\forJob\\dev\\temp\\aaaaa.png");

            using (FileStream stream = File.OpenWrite(@"C:\\Users\\M.Ozama\\forJob\\dev\\temp\\test.ico"))
            {
                Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile("C:\\Users\\M.Ozama\\forJob\\dev\\temp\\aaaaa.png");
                Icon.FromHandle(bitmap.GetHicon()).Save(stream);
            }
        }
    }
}