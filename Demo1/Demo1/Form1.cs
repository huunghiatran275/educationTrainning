using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
using MySql.Data.MySqlClient;
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

        static public String currentUser = "";

        static public List<String> user = new List<String>();
        static public List<String> pass = new List<String>();

        public enum TYPE_CONNECT
        {
            MySQLite = 1,
            MySQL
        };

        public Main()
        {
            InitializeComponent();
            btnRestoreWindown.Hide();
            past_screen = _screen_UI.home;
            current_screen = _screen_UI.home;
            updateUI(_screen_UI.home);

            /*connect database*/
            connectSQlite();
            //connectMySQL();

            /*load data Account*/
            loadDataAccount();
            //loadDataAcountMySQL();

            /*load data of Course Learning*/
            loadDataCourseLearning(TYPE_CONNECT.MySQLite);
            //loadDataCourseLearning(TYPE_CONNECT.MySQL);

            /*load data of Lesson Plant*/
            loadDataLessonPlant(TYPE_CONNECT.MySQLite);
            //loadDataLessonPlant(TYPE_CONNECT.MySQL);
            /*load data of table Matrix*/
            loadDataMatrix(TYPE_CONNECT.MySQLite);
            //loadDataMatrix(TYPE_CONNECT.MySQL);

            //event display pastform when click back
            //add event of customCourseLearning
            customCourseLearning2.action_btnBack_Clicked += HandleScreenPastUI;
            customCourseLearning2.actionLogin += HandleScreenLoginUI;
            //ad event of customLoginAccount
            customLoginAccount1.action_btnCancel_Clicked += HandleScreenPastUI;
            customRegisterAccount1.action_btnCancel_Clicked += HandleScreenPastUI;

            customLessonPlant1.action_btnBack_Clicked += HandleScreenPastUI;
            customMatrix1.action_btnBack_Clicked += HandleScreenPastUI;

            //add event of customLessonPlant
            customLessonPlant1.actionLogin += HandleScreenLoginUI;
            customMatrix1.actionLogin += HandleScreenLoginUI;

            //add event for doubleclick CDR or lesson to show matrix
            customCourseLearning2.action_doubleClick_CDR += HandleScreenMatrixForm1;

            //add event for doubleclick lesson to show matrix
            customLessonPlant1.action_doubleClick_Lesson += HandleScreenMatrixForm2;



            //add event when don't have account and want register
            customLoginAccount1.action_btnSignup_Clicked += HandleScreenRegisterAccount;

            //add event when from screen register to login screen
            customRegisterAccount1.action_btnGoLogin_Clicked += HandleScreenLoginUI;

            //add event show username after login successfull
            customLoginAccount1.action_setUserName += HandleSetUserName;

            //event
            customMatrix1.action_fixColor += HandleFixColor;

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

        //login and logout
        private void btnLogin_Cick(object sender, EventArgs e)
        {
            if (btnLogin.Text.Equals("Login"))
            {
                customLoginAccount1.txtUser.ForeColor = Color.LightGray;
                customLoginAccount1.txtUser.Text = "Username or Email";
                customLoginAccount1.txtPassword.Text = "Password";
                customLoginAccount1.txtPassword.ForeColor = Color.LightGray;
                updateUI(_screen_UI.login);
            }
            else
            {
                if (!MessageBox.Show("Are you sure to Logout?").Equals("null"))
                {
                    inforUserName.Text = "Guest";
                    flag_admin = false;
                    btnLogin.Text = "Login";
                    customLoginAccount1.txtPassword.Text = "";
                    updateUI(_screen_UI.login);
                }
            }
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
        public static int location = -1;

        //handle when doubleclick cell of CDR form
        public void HandleScreenMatrixForm1(object sender, EventArgs e)
        {
            //reset màu bar
            if (location != -1)
            {
                resetColorTableMatrix(location);
            }
            customMatrix1.resetColorCDRbar();

            //go to form matrix
            updateUI(_screen_UI.matrix);
            for (int i = 5; i <= 227; i++)
            {
                if (customMatrix1.tableMatrix.Rows[0].Cells[i].Value.ToString().Equals(customCourseLearning2.chuandaura))
                {
                    Console.WriteLine("vi tri la:" + i);
                    location = i;
                }
            }
            Console.WriteLine("location = " + location);
            Console.WriteLine("count " + customMatrix1.tableMatrix.RowCount);

            for (int i = 1; i < customMatrix1.tableMatrix.RowCount; i++)
            {
                if (location != -1)
                {
                    customMatrix1.tableMatrix.Rows[i].Cells[location].Style.BackColor = Color.Red;
                }
            }
            // sau khi hiện màu xong nếu kích vào chỗ khác thì màu phải chuyển về màu mặc định
            //... xử lý phức tạp nên có thể là chỉ đưa ra đúng vị trí đó thôi không cần hiển thị màu
            // còn hàng thì có thể hiển thị màu khác

            customCourseLearning2.chuandaura = "";
            //hiển thị vị trí ở chỗ đó (scroll bar)
            customMatrix1.tableMatrix.FirstDisplayedScrollingColumnIndex = location - 5;
            customMatrix1.tableMatrix.FirstDisplayedScrollingRowIndex = 0;
            //customMatrix1.tableMatrix.Rows[location].Selected = true;
            //customMatrix1.tableMatrix.Rows[location].Cells[0].Selected = true;
            customMatrix1.tableMatrix.PerformLayout();
        }

        public void HandleResetColorinMain(object sender, EventArgs e)
        {
            if (location != -1)
            {
                resetColorTableMatrix(location);
            }
        }

        public void resetColorTableMatrix(int location)
        {
            for (int i = 1; i < customMatrix1.tableMatrix.RowCount; i++)
            {
                if (i == 5 || i == 20)
                {
                    customMatrix1.tableMatrix.Rows[i].Cells[location].Style.BackColor = Color.FromArgb(153, 180, 209);
                    continue;
                }
                if (i == 21 || i == 44 || i == 62)
                {
                    customMatrix1.tableMatrix.Rows[i].Cells[location].Style.BackColor = Color.FromArgb(164, 214, 224);
                    continue;
                }
                customMatrix1.tableMatrix.Rows[i].Cells[location].Style.BackColor = Color.White;
            }
        }

        //handle when double cell click of lessonPlant form
        int locationLesson = -1;
        public void HandleScreenMatrixForm2(object sender, EventArgs e)
        {

            //reset màu bar
            customMatrix1.resetColorCDRbar();

            Console.WriteLine("test: " + customMatrix1.tableMatrix.Rows[4].Cells[3].Value.ToString());
            for (int i = 0; i < customMatrix1.tableMatrix.RowCount; i++)
            {
                if (customMatrix1.tableMatrix.Rows[i].Cells[3].Value.ToString().Equals(customLessonPlant1.focustLesson))
                {
                    locationLesson = i;
                    Console.WriteLine("location of subject: " + locationLesson);
                    break;
                }
            }
            if (locationLesson != -1)
            {
                //update UI
                updateUI(_screen_UI.matrix);
                //show color

                customMatrix1.tableMatrix.Rows[locationLesson].Selected = true;
                // location scroll bar
                customMatrix1.tableMatrix.FirstDisplayedScrollingRowIndex = locationLesson;
                customMatrix1.tableMatrix.FirstDisplayedScrollingColumnIndex = 0;
                locationLesson = -1;
            }
        }


        //handle event click not a member? signup now
        public void HandleScreenRegisterAccount(object sender, EventArgs e)
        {
            updateUI(_screen_UI.register);
        }

        // set username when login successfull
        public void HandleSetUserName(object sender, EventArgs e)
        {
            inforUserName.Text = currentUser;
            btnLogin.Text = "Logout";
        }

        public void HandleFixColor(object sender, EventArgs e)
        {
            if (location != -1)
            {
                resetColorTableMatrix(location);
            }
        }

        // handle database
        public static SQLiteConnection _Connection;
        public static SQLiteCommand cmd1, cmd2, cmd3;
        public static DataTable data1, data2, data3, dataAccount;

        public static void connectSQlite()
        {

            string _ConnectionString = @"Data Source=database.db;Version=3;New=False;Compress=True";
            _Connection = new SQLiteConnection(_ConnectionString);
            _Connection.Open();
        }
        public static MySqlConnection mysqlConnection;
        public static void connectMySQL()
        {
            MySqlConnectionStringBuilder _stringConnection = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "database",
                UserID = "root",
                Password = "root",
                Port = 3306

            };

            //  string connectionString = "SERVER=sql12.freemysqlhosting.net;PORT=3306;DATABASE=sql12232054;UID=sql12232054;PWD=L2shZZrK4X";
            mysqlConnection = new MySqlConnection(_stringConnection.ToString());
            try
            {
                mysqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Can't connect MySQL");
            }
        }
        public static int nNumbersOfCourseID = 0;
        public void loadDataCourseLearning(TYPE_CONNECT eTypeConnect)
        {
            switch (eTypeConnect)
            {
                case TYPE_CONNECT.MySQLite:
                    {
                        //*sqlite*//
                        String sql = "Select * from ChuanDauRa ";
                        cmd1 = new SQLiteCommand(sql, _Connection);
                        cmd1.ExecuteNonQuery();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd1);
                        data1 = new DataTable();
                        da.Fill(data1);
                        break;
                    }

                case TYPE_CONNECT.MySQL:
                    {
                        //*sqlphpadmin*//

                        MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter();
                        string sql = "Select *from chuandaura";
                        mysqlAdapter.SelectCommand = new MySqlCommand(sql, mysqlConnection);
                        data1 = new DataTable();
                        mysqlAdapter.Fill(data1);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
            foreach (DataRow item in data1.Rows)
            {
                int n = customCourseLearning2.tableCourseLearning.Rows.Add();
                // customCourseLearning2.tableCourseLearning.Rows[n].Cells[0].Value = item["id"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[0].Value = item["level1"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[1].Value = item["level2"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[2].Value = item["level3"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[3].Value = item["level4"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[4].Value = item["CDR"].ToString();
                customCourseLearning2.tableCourseLearning.Rows[n].Cells[5].Value = item["TDNL"].ToString();
                nNumbersOfCourseID = n;
            }

            customCourseLearning2.tableCourseLearning.Rows[78].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customCourseLearning2.tableCourseLearning.Rows[104].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customCourseLearning2.tableCourseLearning.Rows[149].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
        }
        public static int nNumbersOfLessonPlantID = 0;
        public void loadDataLessonPlant(TYPE_CONNECT eTypeConnect)
        {
            switch (eTypeConnect)
            {
                case TYPE_CONNECT.MySQLite:
                    {
                        /*SQLite*/
                        String sql = "Select * from ChuongTrinhDaoTao ";
                        cmd2 = new SQLiteCommand(sql, _Connection);
                        cmd2.ExecuteNonQuery();
                        SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd2);
                        data2 = new DataTable();
                        da1.Fill(data2);
                        break;
                    }

                case TYPE_CONNECT.MySQL:
                    {
                        //*sqlphpadmin*//
                        MySqlDataAdapter mysqlAdapter1 = new MySqlDataAdapter();
                        string sql = "Select *from ChuongTrinhDaoTao";
                        mysqlAdapter1.SelectCommand = new MySqlCommand(sql, mysqlConnection);
                        data2 = new DataTable();
                        mysqlAdapter1.Fill(data2);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
            foreach (DataRow item in data2.Rows)
            {

                int n = customLessonPlant1.tableLessonPlant.Rows.Add();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[0].Value = item["id"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[3].Value = item["SoTC"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[4].Value = item["LT"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[5].Value = item["TH"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[6].Value = item["BT"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[7].Value = item["Loai"].ToString();
                customLessonPlant1.tableLessonPlant.Rows[n].Cells[8].Value = item["KeHoach"].ToString();
                nNumbersOfLessonPlantID = n;

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
            // customLessonPlant1.tableLessonPlant.Rows[150].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            customLessonPlant1.tableLessonPlant.Rows[48].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            customLessonPlant1.tableLessonPlant.Rows[75].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            customLessonPlant1.tableLessonPlant.Rows[115].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);

            //_Connection.Close();
        }

        public void loadDataMatrix(TYPE_CONNECT eTypeConnect)
        {
            switch (eTypeConnect)
            {
                case TYPE_CONNECT.MySQLite:
                    {
                        /*SQLite*/
                        String sql = "Select * from MaTranKyNang ";
                        cmd3 = new SQLiteCommand(sql, _Connection);
                        cmd3.ExecuteNonQuery();
                        SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd3);
                        data3 = new DataTable();
                        da2.Fill(data3);
                        break;
                    }

                case TYPE_CONNECT.MySQL:
                    {
                        /*MySQL*/
                        MySqlDataAdapter mysqlAdapter2 = new MySqlDataAdapter();
                        string sql = "Select *from MaTranKyNang";
                        mysqlAdapter2.SelectCommand = new MySqlCommand(sql, mysqlConnection);
                        data3 = new DataTable();
                        mysqlAdapter2.Fill(data3);
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

            customMatrix1.tableMatrix.DataSource = data3;
            foreach (DataGridViewColumn column in customMatrix1.tableMatrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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

        public void loadDataAcountMySQL()
        {
            String sql = "Select * from account";
            MySqlDataAdapter dataAccount = new MySqlDataAdapter();
            dataAccount.SelectCommand = new MySqlCommand(sql, mysqlConnection);
            DataTable AccountTable = new DataTable();
            dataAccount.Fill(AccountTable);
            foreach (DataRow row in AccountTable.Rows)
            {
                user.Add(row["user"].ToString());
                pass.Add(row["password"].ToString());
            }
            Console.WriteLine(user);
            Console.WriteLine(pass);
        }



    }
}
