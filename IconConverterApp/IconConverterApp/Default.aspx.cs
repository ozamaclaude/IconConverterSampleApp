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
    public class RegisteredFile
    {
        public string RegisterNumber { get; set; }
        public string RegisterDate { get; set; }
        public string RegisterFileName { get; set; }
        public string Notes { get; set; }
    }
    public partial class _Default : Page
    {

        private List<RegisteredFile> _registeredFiles = new List<RegisteredFile>();
        private const string _savePath = @"C:\\Users\M.Ozama\forJob\dev\temp\";
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadBtn.Text = "変換";
            //if (CheckBox1.Checked)
            //{
            //    UploadBtn.Text = "アップロード";
            //    Response.Redirect(Request.Url.ToString());
            //}
        }
        public void StatusChanged(Object sender, EventArgs e)
        {
            UploadBtn.Text = "変換";
            if (CheckBox1.Checked)
            {
                UploadBtn.Text = "アップロード";
            }
            
            UploadBtn.DataBind();
        }

        private void LoadGrid()
        {
            GridView1.DataSource = _registeredFiles;
            GridView1.DataBind();
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

                _registeredFiles.Add(new RegisteredFile
                {
                    RegisterNumber = "1",
                    RegisterDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    RegisterFileName = FileUpLoad1.FileName
                }); ;
                LoadGrid();
            }
            else
            {
                Label1.Text = "No File Uploaded.";
            }

            // ここでは、Iconファイルに変換するルートとする
            if(!CheckBox1.Checked)
            {
                var icoFilePath = Path.Combine(_savePath, fPfx + ".ico");
                using (FileStream stream = File.OpenWrite(icoFilePath))
                {
                    Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(pngPath);
                    Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                }
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanging(Object sender, GridViewSelectEventArgs e)
        {

        }

        protected void Grid1_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                var aaa = 1;
                int index = Convert.ToInt32(e.CommandArgument);
                
                GridViewRow selectedRow = GridView1.Rows[index];
                //TableCell contactName = selectedRow.Cells[1];
                //string contact = contactName.Text;

                
            }
        }

        private static string CurrentFileNamePrefix()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss_");
        }


    }
}