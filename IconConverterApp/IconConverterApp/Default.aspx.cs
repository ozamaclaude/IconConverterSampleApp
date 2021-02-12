using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

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

        private int _orgImageWidth { get; set; }
        private int _orgImageHeight { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            UploadBtn.Text = "変換";

            GridView1.Columns[0].HeaderStyle.Width = 200;
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
            if (!HasUploadFile())
            {
                Label1.Text = "No File Uploaded.";
                string testScript = "alert('ファイルが指定されていません');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "key", testScript, true);
                return;
            }


            var aa = FileUpLoad1.Width;
            //ResizeImageKeepingAspectRatio();
            var fPfx = CurrentFileNamePrefix();
            //var pngFileName = fPfx + "_output.png";
            var pngPath = Path.Combine(_savePath, fPfx + FileUpLoad1.FileName);

            FileUpLoad1.SaveAs(Path.Combine(_savePath, fPfx + FileUpLoad1.FileName));
            Label1.Text = "File Uploaded: " + FileUpLoad1.FileName;

            _registeredFiles.Add(new RegisteredFile
            {
                RegisterNumber = "1",
                RegisterDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                RegisterFileName = FileUpLoad1.FileName
            }); ;
            LoadGrid();

            // ここでは、Iconファイルに変換するルートとする
            if (!CheckBox1.Checked)
            {
                var icoFilePath = Path.Combine(_savePath, fPfx + ".ico");
                using (FileStream stream = File.OpenWrite(icoFilePath))
                {
                    Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(pngPath);
                    Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                }
            }

        }

        private bool HasUploadFile()
        {
            if (FileUpLoad1.HasFile) { return true; }
            return false;
        }



        private void ResizeImageKeepingAspectRatio(string sourcePath, string destPath)
        {
            var selected = DropDownList1.SelectedValue;
            if(selected == "0") { return; }

            using (Image image = Image.FromFile(sourcePath))
            {
                var imgWidth = image.Width;
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