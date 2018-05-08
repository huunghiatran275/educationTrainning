using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
using MySql.Data.MySqlClient;

namespace Demo1
{
    public partial class customCourseLearning : UserControl
    {
        public customCourseLearning()
        {
            InitializeComponent();

            // tableCourseLearning.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            // tableCourseLearning.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(0, 232, 58);
            tableCourseLearning.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            tableCourseLearning.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            tableCourseLearning.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            tableCourseLearning.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            tableCourseLearning.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            //connectSQlite();
            //loadData();
            tableCourseLearning.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 232, 58);
            tableCourseLearning.ColumnHeadersHeight = 70;
            tableCourseLearning.EnableHeadersVisualStyles = false;
        }

        //database

        public SQLiteConnection _Connection;
        public SQLiteCommand cmd;
        public DataTable data;

        public List<int> LocationEdit = new List<int>();
        int checkLoginInt = 1;
        int checkSelect = 0;
        int tmp;
        bool flagInsert = false;
        int nRowInsert = 0;

        // static customCourseLearning customLearn = new customCourseLearning();
        public void connectSQlite()
        {

            string _ConnectionString = @"Data Source=database.db;Version=3;New=False;Compress=True";
            _Connection = new SQLiteConnection(_ConnectionString);
            _Connection.Open();
        }

        public void loadData()
        {


            String sql = "Select * from ChuanDauRa ";
            Main.cmd1 = new SQLiteCommand(sql, Main._Connection);
            Main.cmd1.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(Main.cmd1);
            Main.data1 = new DataTable();
            da.Fill(Main.data1);

            foreach (DataRow item in Main.data1.Rows)
            {
                int n = tableCourseLearning.Rows.Add();
                tableCourseLearning.Rows[n].Cells[0].Value = item["level1"].ToString();
                tableCourseLearning.Rows[n].Cells[1].Value = item["level2"].ToString();
                tableCourseLearning.Rows[n].Cells[2].Value = item["level3"].ToString();
                tableCourseLearning.Rows[n].Cells[3].Value = item["level4"].ToString();
                tableCourseLearning.Rows[n].Cells[4].Value = item["CDR"].ToString();
                tableCourseLearning.Rows[n].Cells[5].Value = item["TDNL"].ToString();


            }
            ReadOnlyDataGridView();

        }

        //event public to another class call
        public event EventHandler action_btnSave_Clicked;
        public event EventHandler action_btnBack_Clicked;
        public event EventHandler action_doubleClick_CDR;

        public void btnBack_Click(object sender, EventArgs e)
        {

            Console.Write("abc");
            if (action_btnBack_Clicked != null)
                action_btnBack_Clicked(this, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (action_btnSave_Clicked != null)
                action_btnSave_Clicked(this, null);
            MessageBox.Show("Save");
            tableCourseLearning.CurrentRow.ReadOnly = true;
            foreach (int tmp in LocationEdit)
            {
                String stt1 = tableCourseLearning.Rows[tmp].Cells[0].Value.ToString();
                String stt2 = tableCourseLearning.Rows[tmp].Cells[1].Value.ToString();
                String stt3 = tableCourseLearning.Rows[tmp].Cells[2].Value.ToString();
                String stt4 = tableCourseLearning.Rows[tmp].Cells[3].Value.ToString();
                String editChuanDauRa = tableCourseLearning.Rows[tmp].Cells[4].Value.ToString();
                String editTrinhDoNangLuc = tableCourseLearning.Rows[tmp].Cells[5].Value.ToString();
                String updateQuery = "UPDATE ChuanDauRa set level1 = '" + stt1 + "', level2 = '" + stt2 + "', level3 = '" + stt3 + "',level4 = '" + stt4 + "',CDR = '" + editChuanDauRa + "',TDNL = '" + editTrinhDoNangLuc + "' WHERE id = " + Main.data1.Rows[tmp][0].ToString();
                Console.WriteLine(updateQuery);
               
                Main.cmd1 = new SQLiteCommand(updateQuery, Main._Connection);
                Main.cmd1.ExecuteNonQuery();

                //MySqlCommand myComand = new MySqlCommand(updateQuery, Main.mysqlConnection);
                //myComand.ExecuteNonQuery();


                //updateDatabase();
            }
            LocationEdit.Clear();
            //save to change when insert
            if (nRowInsert != 0 && flagInsert == true)
            {
                //save insert
                string strlevel1 = tableCourseLearning.Rows[nRowInsert + 1].Cells[0].Value.ToString();
                string strlevel2 = tableCourseLearning.Rows[nRowInsert + 1].Cells[1].Value.ToString();
                string strlevel3 = tableCourseLearning.Rows[nRowInsert + 1].Cells[2].Value.ToString();
                string strlevel4 = tableCourseLearning.Rows[nRowInsert + 1].Cells[3].Value.ToString();
                string strCDR = tableCourseLearning.Rows[nRowInsert + 1].Cells[4].Value.ToString();
                string strTDNL = tableCourseLearning.Rows[nRowInsert + 1].Cells[5].Value.ToString();
                string command = "INSERT INTO ChuanDauRa(id,level1,level2,level3,level4,CDR,TDNL) VALUES('" + (nPosition + 1) + "','" + strlevel1 + "','" + strlevel2 + "','" + strlevel3 + "','" + strlevel4 + "','" + strCDR + "','" + strTDNL + "')";
                MySqlCommand myComand = new MySqlCommand(command, Main.mysqlConnection);
              //  SQLiteCommand myCommand = new SQLiteCommand(command, Main._Connection);
                myComand.ExecuteNonQuery();

                for (int i = 1; i < nCount; i++)
                {
                    nIndex = ++nPosition + 2 + i - nCountDown;
                    string command1 = "UPDATE CHUANDAURA SET id = id - 1 WHERE id >=" + nIndex;
                    Console.WriteLine(command1);
                    //MySqlCommand mycommand2 = new MySqlCommand(command1, Main.mysqlConnection);
                    SQLiteCommand mycommand2 = new SQLiteCommand(command1, Main._Connection);
                    mycommand2.ExecuteNonQuery();
                    nCountDown++;
                }
                flagInsert = false;
            }

        }

        private void tableCourseLearning_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tableCourseLearning.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 232, 58);
        }

        public event HandledEventHandler actionLogin;
        int nPosition = 0;
        int nIndex = 0;
        int nCount = 0;
        int nCountDown = 0;
        private void tableCourseLearning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Main.flag_admin == true)
            {
                
                int rowSelected = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                tmp = rowSelected;
                if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    //delete database
                    MessageBox.Show("Delete");
                    String deleteQuery = "DELETE FROM CHUANDAURA WHERE id=" + Main.data1.Rows[rowSelected][0].ToString();
                    
                    //update sqlite
                   Main.cmd1 = new SQLiteCommand(deleteQuery, Main._Connection);
                   Main.cmd1.ExecuteNonQuery();

                    //update mysql
                    //MySqlCommand myCommand = new MySqlCommand(deleteQuery, Main.mysqlConnection);
                    //myCommand.ExecuteNonQuery();

                    int n = 0;
                    tableCourseLearning.Rows.RemoveAt(rowSelected);
                    Main.data1.Rows.RemoveAt(rowSelected);
                    foreach (DataRow item in Main.data1.Rows)
                    {
                        //int n = tableCourseLearning.Rows.Add();
                        //tableCourseLearning.Rows[n].Cells[0].Value = item["id"].ToString();
                        tableCourseLearning.Rows[n].Cells[0].Value = item["level1"].ToString();
                        tableCourseLearning.Rows[n].Cells[1].Value = item["level2"].ToString();
                        tableCourseLearning.Rows[n].Cells[2].Value = item["level3"].ToString();
                        tableCourseLearning.Rows[n].Cells[3].Value = item["level4"].ToString();
                        tableCourseLearning.Rows[n].Cells[4].Value = item["CDR"].ToString();
                        tableCourseLearning.Rows[n].Cells[5].Value = item["TDNL"].ToString();
                        n++;

                    }

                }
                else if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("edit"))
                {
                    MessageBox.Show("Edit");
                    //login.Visible = true;
                    Console.WriteLine(checkLoginInt);
                    rowSelected = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                    LocationEdit.Add(rowSelected);
                    Console.WriteLine(rowSelected);
                    checkSelect = rowSelected;
                    //dataGridView1.ReadOnly = false;
                    tableCourseLearning.CurrentRow.ReadOnly = false;

                }
                else if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("add"))
                {
                    flagInsert = true;
                    MessageBox.Show("Insert table success. You can enter data and Save it");
                    rowSelected = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                    tableCourseLearning.Rows.Insert(rowSelected + 1);
                    nPosition = rowSelected + 1;
                    nRowInsert = rowSelected;
                    for (int i = Main.nNumbersOfCourseID + 1; i > nPosition; i--)
                    {
                        string commandLine = "UPDATE CHUANDAURA SET id = id + 1 WHERE id>= " + i;
                        nCount++;
                        Console.WriteLine(commandLine);
                        //MySqlCommand myCommand = new MySqlCommand(commandLine, Main.mysqlConnection);
                        SQLiteCommand myCommand = new SQLiteCommand(commandLine, Main._Connection);
                        myCommand.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("edit") || tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete") || tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("add"))
                {
                    MessageBox.Show("Please login before edit table");
                    if (actionLogin != null)
                        actionLogin(this, null);
                }

            }
        }

        //
        void ReadOnlyDataGridView()
        {
            int countRows = tableCourseLearning.RowCount;
            for (int i = 0; i < countRows; i++)
            {
                tableCourseLearning.Rows[i].ReadOnly = true;
            }
        }

        private void tableCourseLearning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tableCourseLearning.Rows[e.RowIndex].Selected = true;
            }

        }

        public String chuandaura = "";
        private void tableCourseLearning_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete")) && !(tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("edit")))
            {
                //thử in ra cái chuẩn đầu ra của nó thử

                int location = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                for (int i = 0; i <= 3; i++)
                {
                    chuandaura += tableCourseLearning.Rows[location].Cells[i].Value.ToString() + ".";
                }
                // lấy được chuẩn đầu ra
                // h đem nó so sánh với các chuẩn đầu ra bên kia vào nhảy qua bảng bên kia
                if (chuandaura.Length >= 8)
                {
                    chuandaura = chuandaura.Remove(chuandaura.Length - 1);
                    Console.WriteLine("chuan dau ra la: " + chuandaura);
                    if (action_doubleClick_CDR != null)
                        action_doubleClick_CDR(this, null);
                }
                else
                {
                    chuandaura = "";
                }

            }
        }
    }

}
