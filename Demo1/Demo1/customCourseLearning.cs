using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Finisar.SQLite;

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
        int locationRowSeclectPast = -1;
        int locationRowSelectCurrent = -1;
        int checkSelect = 0;
        int tmp;

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
            MessageBox.Show("Confirm");
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

                //updateDatabase();
            }
            LocationEdit.Clear();

        }

        private void tableCourseLearning_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tableCourseLearning.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(0, 232, 58);
        }

        public event HandledEventHandler actionLogin;
        private void tableCourseLearning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (Main.flag_admin == true)
            {
                int rowSelected = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                tmp = rowSelected;
                if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    //delete database
                    rowSelected = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                    //MessageBox.Show(dataGridView1.SelectedRows[rowSelected].Cells[3].Value.ToString());
                    //MessageBox.Show(dataGridView1.Rows[rowSelected].Cells[2].Value.ToString());
                    MessageBox.Show("Delete");
                    String deleteQuery = "DELETE FROM CHUANDAURA WHERE id=" + Main.data1.Rows[rowSelected][0].ToString();
                    Main.cmd1 = new SQLiteCommand(deleteQuery, Main._Connection);
                    Main.cmd1.ExecuteNonQuery();
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
            }
            else
            {
                if (tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("edit") || tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete"))
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

            int checkColor = -1;
            void checkLocationSelect(int location)
            {
                if (tableCourseLearning.Rows[location].DefaultCellStyle.BackColor.Equals(Color.FromArgb(153, 180, 209)))
                    checkColor = 1;
                if (tableCourseLearning.Rows[location].DefaultCellStyle.BackColor.Equals(Color.FromArgb(164, 214, 224)))
                    checkColor = 2;
            }

            private void tableCourseLearning_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                /*locationRowSeclectPast = locationRowSelectCurrent;
                locationRowSelectCurrent = Convert.ToInt32(tableCourseLearning.CurrentRow.Index);
                if (!tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    //reset màu của thằng chọn past và hiện màu của thằng chọn current
                    if (locationRowSeclectPast != -1)
                    {
                        //reset về màu trắng
                        if (checkColor == 1)
                        {
                            tableCourseLearning.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);

                        }

                        if (checkColor == 2)
                        {
                           tableCourseLearning.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);

                        }
                        if (checkColor == -1)
                        {
                            tableCourseLearning.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.White;

                        }
                    }
                    checkColor = -1;
                    checkLocationSelect(locationRowSelectCurrent);
                    Console.WriteLine("checkColor = " + checkColor);
                    tableCourseLearning.Rows[locationRowSelectCurrent].DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);

                }*/
                if (e.RowIndex >= 0)
                {
                    tableCourseLearning.Rows[e.RowIndex].Selected = true;
                }

            }

            public String chuandaura = "";
            private void tableCourseLearning_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if(!(tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("delete")) && !(tableCourseLearning.Columns[e.ColumnIndex].Name.Equals("edit")))
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
                        chuandaura = chuandaura.Remove(chuandaura.Length-1);
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
