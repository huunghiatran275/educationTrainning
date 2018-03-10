using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Finisar.SQLite;
namespace Demo1
{   
    public partial class Main : Form
    {   
        // size format of windown
        const int width_default = 1100;
        const int height_default = 740;

        //location format of windown
        const int w_location = 100;
        const int h_location = 0;

        // flag show panel login or register acc
        static public bool flag_login = false;
        static public bool flag_admin = false;
        
        static public List<String> user = new List<String>();
        static public List<String> pass = new List<String>();
        
        public Main()
        {
            InitializeComponent();
            btnRestoreWindown.Hide();
            past_screen = _screen_UI.home;
            current_screen = _screen_UI.home;
            updateUI(_screen_UI.home);

            //btnCourseGoals.Enabled = true;
           //customCourseLearning2.connectSQlite();
           connectSQlite();
           customCourseLearning2.loadData();


           
           loadDataAccount();
            //loadDataCourseLearning();

            //loadDataLessonPlant();
           customLessonPlant1.loadDataLessonPlant();

            //loadDataMatrix();
           customMatrix1.loadDataMatrix();

            //event display pastform when click back
            //add event of customCourseLearning
            customCourseLearning2.action_btnBack_Clicked += HandleScreenPastUI;
            customCourseLearning2.actionLogin += HandleScreenLoginUI;
            //ad event of customLoginAccount
            customLoginAccount1.action_btnCancel_Clicked += HandleScreenPastUI;
            customLessonPlant1.action_btnBack_Clicked += HandleScreenPastUI;
            customMatrix1.action_btnBack_Clicked += HandleScreenPastUI;

            //add event of customLessonPlant
            customLessonPlant1.actionLogin += HandleScreenLoginUI;
            customMatrix1.actionLogin += HandleScreenLoginUI;

            //add event for doubleclick CDR or lesson to show matrix
            customCourseLearning2.action_doubleClick_CDR += HandleScreenMatrixForm1;

            //add event for doubleclick lesson to show matrix
            customLessonPlant1.action_doubleClick_Lesson += HandleScreenMatrixForm2;

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Location = new Point(w_location, h_location);
        }

        //resize form with size of PC
        private void btnResizeWindown_Click(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            btnResizeWindown.Hide();
            btnRestoreWindown.Show();

        }

        private void btnMinimiSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // resize form return format size
        private void btnRestoreWindown_Click(object sender, EventArgs e)
        {
            this.Location = new Point(w_location, h_location);
            this.Size = new Size(width_default, height_default);
            btnResizeWindown.Show();
            btnRestoreWindown.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // resize menu progress bar
        private void btnMinisize_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 47)
            {
                menuPanel.Width = 200;
                
            }
            else
            {
                //bunifuTransition2.HideSync(menuPanel);
                menuPanel.Width = 47;
                
                //bunifuTransition2.ShowSync(menuPanel);
                
            }
            
           
        }

        public void resetChooseAfter()
        {
            btnDashboard.Normalcolor = Color.FromArgb(32, 46, 59);
            btnCourseGoals.Normalcolor = Color.FromArgb(32, 46, 59);
            btnCourseLearn.Normalcolor = Color.FromArgb(32, 46, 59);
            btnLessonPlant.Normalcolor = Color.FromArgb(32, 46, 59);
            btnMatrix.Normalcolor = Color.FromArgb(32, 46, 59);

        }

        // static can use another class
        public void updateUI(_screen_UI screen)
        {
            resetChooseAfter();
            userPanel.Hide();
            past_screen = current_screen;
            current_screen = screen;
            switch (screen)
            { 
                case _screen_UI.home:
                    btnDashboard.Normalcolor = Color.FromArgb(221, 79, 67);
                    customMatrix1.Show();
                    customCourceGoals1.BringToFront();
                    customCourceGoals1.Show();
                    customLoginAccount1.Hide();
                    customCourseLearning2.Hide();
                    customRegisterAccount1.Hide();
                    customLessonPlant1.Hide();
                    
                    break;

                case _screen_UI.courceGoals:
                    btnCourseGoals.Normalcolor = Color.FromArgb(221, 79, 67);
                    customCourceGoals1.Show();
                    customLoginAccount1.Hide();
                    customRegisterAccount1.Hide();
                    customCourseLearning2.Hide();
                    customLessonPlant1.Hide();
                    customMatrix1.Hide();
                    break;

                case _screen_UI.courceLearn:
                    btnCourseLearn.Normalcolor = Color.FromArgb(221, 79, 67);
                    customCourceGoals1.Hide();
                    customLoginAccount1.Hide();
                    customRegisterAccount1.Hide();
                    customCourseLearning2.Show();
                    customLessonPlant1.Hide();
                    customMatrix1.Hide();
                    break;

                case _screen_UI.LessonPlant:
                    btnLessonPlant.Normalcolor = Color.FromArgb(221, 79, 67);
                    customCourceGoals1.Hide();
                    customLoginAccount1.Hide();
                    customCourseLearning2.Hide();
                    customRegisterAccount1.Hide();
                    customLessonPlant1.Show();
                    customMatrix1.Hide();
                    break;

                case _screen_UI.matrix:
                    btnMatrix.Normalcolor = Color.FromArgb(221, 79, 67);
                    customCourceGoals1.Hide();
                    customLoginAccount1.Hide();
                    customCourseLearning2.Hide();
                    customRegisterAccount1.Hide();
                    customLessonPlant1.Hide();
                    customMatrix1.BringToFront();
                    customMatrix1.Show();
                    break;

                case _screen_UI.login:
                    customCourceGoals1.Hide();
                    customCourseLearning2.Hide();
                    customRegisterAccount1.Hide();
                    customLoginAccount1.Show();
                    customLessonPlant1.Hide();
                    customMatrix1.Hide();
                    break;

                case _screen_UI.register:
                    customCourceGoals1.Hide();
                    customCourseLearning2.Hide();
                    customLoginAccount1.Hide();
                    customRegisterAccount1.Show();
                    customLessonPlant1.Hide();
                    customMatrix1.Hide();
                    break;

                default:
                    break;
                    
            }
        }

        

        private void handlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // handle main
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
            updateUI(_screen_UI.home);
        }

        private void btnCourseGoals_Click(object sender, EventArgs e)
        {
            updateUI(_screen_UI.courceGoals);
            customCourceGoals1.BringToFront();
            customCourceGoals1.Show();
        }

        private void btnCourseLearn_Click(object sender, EventArgs e)
        {
            updateUI(_screen_UI.courceLearn);
        }

        private void btnLessonPlant_Click(object sender, EventArgs e)
        {
            updateUI(_screen_UI.LessonPlant);
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            updateUI(_screen_UI.matrix);
        }

        private void btnLogin_Cick(object sender, EventArgs e)
        {
            updateUI(_screen_UI.login);
            flag_login = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            updateUI(_screen_UI.register);
            flag_login = false;
        }
        private void inforUserName_Click(object sender, EventArgs e)
        {
            
            if (flag_login == false)
            {
                inforUserName.Normalcolor = Color.FromArgb(41, 76, 119);
                userPanel.BringToFront();
                bunifuTransition1.ShowSync(userPanel);
               //userPanel.Show();
                flag_login = true;
            }
            else
            {
                inforUserName.Normalcolor = Color.FromArgb(153, 180, 209);
                //userPanel.Hide();
                bunifuTransition1.HideSync(userPanel);
                flag_login = false;
            }
        }

        //action back in customCourceLearning 
        public void HandleScreenPastUI(object sender, EventArgs e)
        {
            //Do something here
            if (past_screen == _screen_UI.login || past_screen == _screen_UI.register)
            {
                updateUI(_screen_UI.home);
            }
            else
            {
                updateUI(past_screen);
            }
        }

        //action login
        public void HandleScreenLoginUI(object sender, EventArgs e)
        {
            updateUI(_screen_UI.login);
        }

        public void HandleRequestLogin(object sender, EventArgs e)
        { 
            
        }

        //
        int location = -1;
        public void HandleScreenMatrixForm1(object sender, EventArgs e)
        {
            //chuyển giao diện qua matrix
            updateUI(_screen_UI.matrix);
            //so sánh chuẩn đầu ra và hiện màu cho cột đó
                //lấy được vị trí
            
            for (int i = 5; i <= 227; i++)
            {
                if(customMatrix1.tableMatrix.Rows[0].Cells[i].Value.ToString().Equals(customCourseLearning2.chuandaura))
                {
                    Console.WriteLine("vi tri la:" + i);
                    location = i;
                }
            }
                // chỉnh màu cho cột đó sáng lên
            Console.WriteLine("location = " + location);
            Console.WriteLine("count " + customMatrix1.tableMatrix.RowCount);
            
            for (int i = 0; i < customMatrix1.tableMatrix.RowCount;i++ )
            {   
                
                customMatrix1.tableMatrix.Rows[i].Cells[location].Style.BackColor = Color.Red;
            }
            // sau khi hiện màu xong nếu kích vào chỗ khác thì màu phải chuyển về màu mặc định
            //... xử lý phức tạp nên có thể là chỉ đưa ra đúng vị trí đó thôi không cần hiển thị màu
            // còn hàng thì có thể hiển thị màu khác

                customCourseLearning2.chuandaura = "";
            //hiển thị vị trí ở chỗ đó (scroll bar)
                customMatrix1.tableMatrix.FirstDisplayedScrollingColumnIndex = location - 5;
                customMatrix1.tableMatrix.Rows[location].Selected = true;
                customMatrix1.tableMatrix.Rows[location].Cells[0].Selected = true;
                customMatrix1.tableMatrix.PerformLayout();
        }

        int locationLesson = -1;
        public void HandleScreenMatrixForm2(object sender, EventArgs e)
        {
            Console.WriteLine("test: " + customMatrix1.tableMatrix.Rows[4].Cells[3].Value.ToString());
            for(int i = 0;i<customMatrix1.tableMatrix.RowCount;i++)
            {
                if(customMatrix1.tableMatrix.Rows[i].Cells[3].Value.ToString().Equals(customLessonPlant1.focustLesson))
                {
                    locationLesson = i;
                    Console.WriteLine("vi tri cua mon hoc la: " + locationLesson);
                    break;
                }
            }
            if(locationLesson!=-1)
            {
                //update UI
                updateUI(_screen_UI.matrix);
                //hiển thị khác màu

                customMatrix1.changeColorRow(locationLesson);
                // location scroll bar
                customMatrix1.tableMatrix.FirstDisplayedScrollingRowIndex = locationLesson;
                locationLesson = -1;
            }
        }

        // handle database
        public static SQLiteConnection _Connection;
        public static SQLiteCommand cmd1,cmd2,cmd3;
        public static DataTable data1,data2,data3,dataAccount;

        public static void connectSQlite()
        {

            string _ConnectionString = @"Data Source=database.db;Version=3;New=False;Compress=True";
            _Connection = new SQLiteConnection(_ConnectionString);
            _Connection.Open();
        }

        public void loadDataCourseLearning()
        {


            String sql = "Select * from ChuanDauRa ";
            cmd1 = new SQLiteCommand(sql, _Connection);
            cmd1.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd1);
            data1 = new DataTable();
            da.Fill(data1);

            foreach (DataRow item in data1.Rows)
            {
                int n = customCourseLearning2.tableCourseLearning.Rows.Add();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[0].Value = item["id"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[1].Value = item["level1"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[2].Value = item["level2"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[3].Value = item["level3"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[4].Value = item["level4"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[5].Value = item["CDR"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[6].Value = item["TDNL"].ToString();


            }

            customCourseLearning2.tableCourseLearning.Rows[78].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customCourseLearning2.tableCourseLearning.Rows[104].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customCourseLearning2.tableCourseLearning.Rows[149].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);

            //customCourseLearning2.tableCourseLearning.ColumnHeader.DefaultCellStyle.BackColor = Color.FromArgb(0, 232, 58);
            //customCourseLearning2.tableCourseLearning.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(0, 232, 58);
            //_Connection.Close();
        }

        public void loadDataLessonPlant()
        {


            String sql = "Select * from ChuongTrinhDaoTao ";
            cmd2 = new SQLiteCommand(sql, _Connection);
            cmd2.ExecuteNonQuery();
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd2);
            data2 = new DataTable();
            da1.Fill(data2);

            foreach (DataRow item in data2.Rows)
            {
                int n = customLessonPlant1.tableLessonPlant.Rows.Add();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[0].Value = item["stt"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[3].Value = item["SoTC"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[4].Value = item["LT"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[5].Value = item["TH"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[6].Value = item["BT"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[7].Value = item["Loai"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[8].Value = item["KeHoach"].ToString();

            }
            customLessonPlant1.tableLessonPlant.Rows[5].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[15].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[26].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[37].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[47].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[54].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[65].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[74].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[87].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[104].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[114].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[128].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[140].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[150].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[48].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            customLessonPlant1.tableLessonPlant.Rows[75].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            customLessonPlant1.tableLessonPlant.Rows[115].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);




            //_Connection.Close();
        }

        public void loadDataMatrix()
        {


            String sql = "Select * from MaTranKyNang ";
            cmd3 = new SQLiteCommand(sql, _Connection);
            cmd3.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd3);
            data3 = new DataTable();
            da2.Fill(data3);

            //foreach (DataRow item in data2.Rows)
            //{
            //    int n = customLessonPlant1.tableLessonPlant.Rows.Add();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[0].Value = item["stt"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[3].Value = item["SoTC"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[4].Value = item["LT"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[5].Value = item["TH"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[6].Value = item["BT"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[7].Value = item["Loai"].ToString();
            //    customLessonPlant1.tableLessonPlant.Rows[n].Cells[8].Value = item["KeHoach"].ToString();


            //}
            //_Connection.Close();

            // xu ly kich thuoc

            //data3.Columns[2].MaxLength = 50;
            customMatrix1.tableMatrix.DataSource = data3;
            //customMatrix1.tableMatrix.EnableHeadersVisualStyles = true;
            //customMatrix1.tableMatrix.RowHeadersWidth = 60;
            //customMatrix1.tableMatrix.ColumnHeadersHeight = 50;
            foreach (DataGridViewColumn column in customMatrix1.tableMatrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            customMatrix1.tableMatrix.Rows[3].DefaultCellStyle.BackColor = Color.Red;
        }

        public void loadDataAccount()
        {
            String sql = "Select * from account ";
            cmd3 = new SQLiteCommand(sql, _Connection);
            cmd3.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd3);
            dataAccount = new DataTable();
            da2.Fill(dataAccount);

            foreach (DataRow row in dataAccount.Rows)
            {
                user.Add(row["user"].ToString());
                pass.Add(row["pass"].ToString());
            }
            Console.WriteLine(user);
            Console.WriteLine(pass);

        }
        

        
    }
}
