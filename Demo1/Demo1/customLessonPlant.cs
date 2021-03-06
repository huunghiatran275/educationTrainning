﻿using System;
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
    public partial class customLessonPlant : UserControl
    {
        public customLessonPlant()
        {
            InitializeComponent();
            for (int i = 0; i <= 11;i++ )
            {
                tableLessonPlant.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            }
            tableLessonPlant.EnableHeadersVisualStyles = false;
        }

        //event
        public event EventHandler action_btnSave_Clicked;
        public event EventHandler action_btnBack_Clicked;
        public event EventHandler actionLogin;
        public event EventHandler action_doubleClick_Lesson;
        int tmp;

        bool flagInsert = false;
        int nRowInsert = 0;
        public List<int> locationEdit = new List<int>();
        int rowSelected = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (action_btnSave_Clicked != null)
                action_btnSave_Clicked(this, null);
            MessageBox.Show("Saved!");
            //test
            //tableLessonPlant.Rows.Insert(5, "");
            tableLessonPlant.CurrentRow.ReadOnly = true;
            //checkEdit = 1;
            foreach (int tmp in locationEdit)
            {
                String mamonhoc = tableLessonPlant.Rows[tmp].Cells[1].Value.ToString();
                String tenmonhoc = tableLessonPlant.Rows[tmp].Cells[2].Value.ToString();
                String sotc = tableLessonPlant.Rows[tmp].Cells[3].Value.ToString();
                String lythuyet = tableLessonPlant.Rows[tmp].Cells[4].Value.ToString();
                String thuchanh = tableLessonPlant.Rows[tmp].Cells[5].Value.ToString();
                String baitap = tableLessonPlant.Rows[tmp].Cells[6].Value.ToString();
                String loai = tableLessonPlant.Rows[tmp].Cells[7].Value.ToString();
                String kehoach = tableLessonPlant.Rows[tmp].Cells[8].Value.ToString();

                String updateQuery = "UPDATE CHUONGTRINHDAOTAO set MaMonHoc = '" + mamonhoc + "', TenMonHoc = '" + tenmonhoc + "', SoTC = '" + sotc + "',LT = '" + lythuyet + "',TH = '" + thuchanh + "',BT = '" + baitap + "',LOAI = '" + loai + "',KeHoach = '" + kehoach + "' WHERE stt = " + Main.data2.Rows[tmp][0].ToString();
                Console.WriteLine(updateQuery);
                Main.cmd2 = new SQLiteCommand(updateQuery, Main._Connection);
                Main.cmd2.ExecuteNonQuery();
            }

            //save to change when insert
            if (nRowInsert != 0 && flagInsert ==true)
            {
                //save insert
                string strSTT = tableLessonPlant.Rows[nRowInsert + 1].Cells[0].Value.ToString();
                string strMaMH = tableLessonPlant.Rows[nRowInsert + 1].Cells[1].Value.ToString();
                string strTenMH = tableLessonPlant.Rows[nRowInsert + 1].Cells[2].Value.ToString();
                string strSTC = tableLessonPlant.Rows[nRowInsert + 1].Cells[3].Value.ToString();
                string strLT = tableLessonPlant.Rows[nRowInsert + 1].Cells[4].Value.ToString();
                string strTH = tableLessonPlant.Rows[nRowInsert + 1].Cells[5].Value.ToString();
                string strBT = tableLessonPlant.Rows[nRowInsert + 1].Cells[6].Value.ToString();
                string strLoai = tableLessonPlant.Rows[nRowInsert + 1].Cells[7].Value.ToString();
                string strKH = tableLessonPlant.Rows[nRowInsert + 1].Cells[8].Value.ToString();
                string command = "INSERT INTO CHUONGTRINHDAOTAO(stt,id,MaMonHoc,TenMonHoc,SoTC,LT,TH,BT,Loai,KeHoach) VALUES('" + (nPosition + 1) + "','" + strSTT + "','" + strMaMH + "','" + strTenMH + "','" + strSTC + "','" + strLT + "','" + strTH + "','" + strBT + "','" + strLoai + "','" + strKH + "')";
                //MySqlCommand myComand = new MySqlCommand(command, Main.mysqlConnection);
                SQLiteCommand myCommand = new SQLiteCommand(command, Main._Connection);
                myCommand.ExecuteNonQuery();

                for (int i = 1; i < nCount; i++)
                {
                    nIndex = ++nPosition + 2 + i - nCountDown;
                    string command1 = "UPDATE CHUONGTRINHDAOTAO SET stt = stt - 1 WHERE stt >=" + nIndex;
                    Console.WriteLine(command1);
                    //MySqlCommand mycommand2 = new MySqlCommand(command1, Main.mysqlConnection);
                    SQLiteCommand mycommand2 = new SQLiteCommand(command1, Main._Connection);
                    mycommand2.ExecuteNonQuery();
                    nCountDown++;
                }
                flagInsert = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(flagInsert == true)
            {
                flagInsert = false;
            }
            if (action_btnBack_Clicked != null)
            {
                action_btnBack_Clicked(this, null);
            }
        }

        private void tableLessonPlant_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        public void loadDataLessonPlant()
        {


            String sql = "Select * from ChuongTrinhDaoTao ";
            Main.cmd2 = new SQLiteCommand(sql, Main._Connection);
            Main.cmd2.ExecuteNonQuery();
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(Main.cmd2);
            Main.data2 = new DataTable();
            da1.Fill(Main.data2);

            foreach (DataRow item in Main.data2.Rows)
            {
                int n = tableLessonPlant.Rows.Add();
                tableLessonPlant.Rows[n].Cells[0].Value = item["id"].ToString();
                tableLessonPlant.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
                tableLessonPlant.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
                tableLessonPlant.Rows[n].Cells[3].Value = item["SoTC"].ToString();
                tableLessonPlant.Rows[n].Cells[4].Value = item["LT"].ToString();
                tableLessonPlant.Rows[n].Cells[5].Value = item["TH"].ToString();
                tableLessonPlant.Rows[n].Cells[6].Value = item["BT"].ToString();
                tableLessonPlant.Rows[n].Cells[7].Value = item["Loai"].ToString();
                tableLessonPlant.Rows[n].Cells[8].Value = item["KeHoach"].ToString();

            }
            tableLessonPlant.Rows[5].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[15].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[26].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[37].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[47].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[54].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[65].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[74].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[87].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[104].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[114].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[128].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[140].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            //tableLessonPlant.Rows[150].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableLessonPlant.Rows[48].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            tableLessonPlant.Rows[75].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            tableLessonPlant.Rows[115].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);

            ReadOnlyDataGridView();

            //_Connection.Close();
        }

        void ReadOnlyDataGridView()
        {
            int countRows = tableLessonPlant.RowCount;
            for (int i = 0; i < countRows; i++)
            {
                tableLessonPlant.Rows[i].ReadOnly = true;
            }
        }

      ///  int checkEdit = 1;
        int checkSelect = -1;
        //insert
        int nPosition = 0;
        int nIndex = 0;
        int nCount = 0;
        int nCountDown = 0;
        private void tableLessonPlant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   

            if (Main.flag_admin == true)
            {
                rowSelected = Convert.ToInt32(tableLessonPlant.CurrentRow.Index);
                tmp = rowSelected;
                if (tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    //delete database
                    rowSelected = Convert.ToInt32(tableLessonPlant.CurrentRow.Index);
                    //MessageBox.Show(dataGridView1.SelectedRows[rowSelected].Cells[3].Value.ToString());
                    //MessageBox.Show(dataGridView1.Rows[rowSelected].Cells[2].Value.ToString());
                    MessageBox.Show("Delete");

                    String deleteQuery = "DELETE FROM CHUONGTRINHDAOTAO WHERE stt=" + Main.data2.Rows[rowSelected][0].ToString();
                    Console.WriteLine(deleteQuery);
                    SQLiteCommand lpcmd = new SQLiteCommand(deleteQuery, Main._Connection);
                    //Main.cmd2 = new SQLiteCommand(deleteQuery, Main._Connection);
                    //Main.cmd2.ExecuteNonQuery();
                    lpcmd.ExecuteNonQuery();
                    int n = 0;
                    tableLessonPlant.Rows.RemoveAt(rowSelected);
                    Main.data2.Rows.RemoveAt(rowSelected);
                    foreach (DataRow item in Main.data2.Rows)
                    {
                        //int n = tableLessonPlant.Rows.Add();
                        tableLessonPlant.Rows[n].Cells[0].Value = item["id"].ToString();
                        tableLessonPlant.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
                        tableLessonPlant.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
                        tableLessonPlant.Rows[n].Cells[3].Value = item["SoTC"].ToString();
                        tableLessonPlant.Rows[n].Cells[4].Value = item["LT"].ToString();
                        tableLessonPlant.Rows[n].Cells[5].Value = item["TH"].ToString();
                        tableLessonPlant.Rows[n].Cells[6].Value = item["BT"].ToString();
                        tableLessonPlant.Rows[n].Cells[7].Value = item["Loai"].ToString();
                        tableLessonPlant.Rows[n].Cells[8].Value = item["KeHoach"].ToString();
                        n++;

                    }

                }
                else if (tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("edit"))
                {
                    MessageBox.Show("Edit");
                    //login.Visible = true;
                   // checkEdit = 2;
                    rowSelected = Convert.ToInt32(tableLessonPlant.CurrentRow.Index);
                    locationEdit.Add(rowSelected);
                    Console.WriteLine(rowSelected);
                    checkSelect = rowSelected;
                    //dataGridView1.ReadOnly = false;
                    tableLessonPlant.CurrentRow.ReadOnly = false;

                }
                if (tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("add"))
                {
                    flagInsert = true;
                    MessageBox.Show("Insert");
                    rowSelected = Convert.ToInt32(tableLessonPlant.CurrentRow.Index);
                    nRowInsert = rowSelected;
                    tableLessonPlant.Rows.Insert(rowSelected + 1);
                    nPosition = rowSelected + 1;
                    for (int i = Main.nNumbersOfLessonPlantID + 1; i > nPosition;i-- )
                    {
                        string commandLine = "UPDATE CHUONGTRINHDAOTAO SET stt = stt + 1 WHERE stt>= " + i;
                        nCount++;
                        Console.WriteLine(commandLine);
                        //MySqlCommand myCommand = new MySqlCommand(commandLine, Main.mysqlConnection);
                        SQLiteCommand myCommand = new SQLiteCommand(commandLine, Main._Connection);
                        myCommand.ExecuteNonQuery();
                    }

                    //    tableLessonPlant.Rows.Insert(e.RowIndex, "");
                    //String deleteQuery = "INSERT INTO CHUONGTRINHDAOTAO(id, MaMonHoc, TenMonHoc,SoTC,LT,TH,BT,Loai,KeHoach) VALUES(10,'','','','','','','','')";
                    //Console.WriteLine(deleteQuery);
                    //SQLiteCommand lpcmd = new SQLiteCommand(deleteQuery, Main._Connection);
                    //lpcmd.ExecuteNonQuery();
                    
                    //save database
                }
            }
            else
            {
                if (tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("edit") || tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("delete") || tableLessonPlant.Columns[e.ColumnIndex].Name.Equals("add"))
                {
                    MessageBox.Show("Please login before edit table");
                    if (actionLogin != null)
                        actionLogin(this, null);
                }

            }
        }


        private void tableLessonPlant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tableLessonPlant.Rows[e.RowIndex].Selected = true;
            }

        }

        public void changeColorRow()
        {

        }

        public String focustLesson = "";
        private void tableLessonPlant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!(tableLessonPlant.Columns[e.ColumnIndex].Equals("delete")) && !(tableLessonPlant.Columns[e.ColumnIndex].Equals("edit")))
            {
                int location = Convert.ToInt32(tableLessonPlant.CurrentRow.Index);
                String lesson = tableLessonPlant.Rows[location].Cells[2].Value.ToString();
                Console.WriteLine("lesson: " + lesson);
                if(!lesson.Equals(""))
                {
                    //creat event action
                    focustLesson = lesson;
                    if (action_doubleClick_Lesson != null)
                        action_doubleClick_Lesson(this, null);

                }
            }
        }
       
    }

}
