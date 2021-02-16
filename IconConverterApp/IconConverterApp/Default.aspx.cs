using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;
using Npgsql;
using System.Transactions;
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

        private const string _connectionString 
            = "Server=localhost;Port=5432;User ID=postgres;Database=postgres;Password=postgres;Enlist=true";

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

        /// <summary>
        /// 画像ファイルのアスペクト比を維持してサイズを変更
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        private void ResizeImageKeepingAspectRatio(
            string sourcePath, 
            string destPath,
            ImageFormat imgFormat,
            int width,
            int height)
        {
            var selected = DropDownList1.SelectedValue;
            if(selected == "0") { return; }

            using (Image image = Image.FromFile(sourcePath))
            {
                // 変更倍率を取得する
                float scale = Math.Min((float)width / (float)image.Width, (float)height / (float)image.Height);

                // サイズ変更した画像を作成する
                using (Bitmap bitmap = new Bitmap(width, height))
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // 変更サイズを取得する
                    int widthToScale = (int)(image.Width * scale);
                    int heightToScale = (int)(image.Height * scale);

                    // 背景色を塗る
                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    graphics.FillRectangle(solidBrush, new RectangleF(0, 0, width, height));

                    // サイズ変更した画像に、左上を起点に変更する画像を描画する
                    graphics.DrawImage(image, 0, 0, widthToScale, heightToScale);

                    // サイズ変更した画像を保存する
                    bitmap.Save(destPath, imgFormat);
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

        private void AddFile()
        {
            NpgsqlCommand cmd = null;
            string cmd_str = null;
            using (TransactionScope ts = new TransactionScope())
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    // TODO: プレースホルダを使う
                    cmd_str = "insert into stored_files values ";

                    cmd = new NpgsqlCommand(cmd_str, conn);
                    cmd.ExecuteNonQuery();

                }


            }
        }

        private static string CurrentFileNamePrefix()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss_");
        }

    }
}