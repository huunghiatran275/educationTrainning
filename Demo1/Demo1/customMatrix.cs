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
    public partial class customMatrix : UserControl
    {
        public customMatrix()
        {
            InitializeComponent();
            //can edit styles for table
            tableMatrix.EnableHeadersVisualStyles = false;
        }

        private void tableMatrix_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {   
            //set backcolor for header
            tableMatrix.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(0, 232, 58);

            //set backcolor for some rows title
            tableMatrix.Rows[5].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableMatrix.Rows[20].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
            tableMatrix.Rows[21].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            tableMatrix.Rows[44].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
            tableMatrix.Rows[62].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);
           // tableMatrix.Rows[81].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);

            tableMatrix.Rows[0].DefaultCellStyle.Font = new Font("Tahoma", 10.0F, FontStyle.Bold);
            tableMatrix.Rows[0].Height = 35;

            ReadOnlyDataGridView();
        }

        public event EventHandler actionLogin;
        public event EventHandler action_btnBack_Clicked;
        List<int> locationEdit = new List<int>();

        int locationRowSeclectPast = -1;
        int locationRowSelectCurrent = -1;

        private void btnChange_Click(object sender, EventArgs e)
        {
            //set dieu kien dang nhap
            //neu ok thi hien thi nut save
            //MessageBox.Show("Please login before edit table");
            //if (actionLogin != null)
            //    actionLogin(this, null);
            MessageBox.Show("Saved!");
            tableMatrix.CurrentRow.ReadOnly = true;
            foreach (int tmp in locationEdit)
            {
                //String mamonhoc = tableLessonPlant.Rows[tmp].Cells[1].Value.ToString();
                //String tenmonhoc = tableLessonPlant.Rows[tmp].Cells[2].Value.ToString();
                //String sotc = tableLessonPlant.Rows[tmp].Cells[3].Value.ToString();
                //String lythuyet = tableLessonPlant.Rows[tmp].Cells[4].Value.ToString();
                //String thuchanh = tableLessonPlant.Rows[tmp].Cells[5].Value.ToString();
                //String baitap = tableLessonPlant.Rows[tmp].Cells[6].Value.ToString();
                //String loai = tableLessonPlant.Rows[tmp].Cells[7].Value.ToString();
                //String kehoach = tableLessonPlant.Rows[tmp].Cells[8].Value.ToString();
                String query = "";
                for (int i = 0; i <= 227; i++)
                {
                    String field = tableMatrix.Rows[tmp].Cells[2 + i].Value.ToString();
                    query =query +  "field" + i + "= '"+ field +"',";

                }
                Console.WriteLine(query);
                query = query.Remove(query.Length - 1);
                String updateQuery = "UPDATE MatranKyNang set " + query + " WHERE stt = " + Main.data3.Rows[tmp][228].ToString();
                //String updateQuery = "UPDATE CHUONGTRINHDAOTAO set MaMonHoc = '" + mamonhoc + "', TenMonHoc = '" + tenmonhoc + "', SoTC = '" + sotc + "',LT = '" + lythuyet + "',TH = '" + thuchanh + "',BT = '" + baitap + "',LOAI = '" + loai + "',KeHoach = '" + kehoach + "' WHERE stt = " + Main.data2.Rows[tmp][0].ToString();
                Console.WriteLine(updateQuery);
                Main.cmd3 = new SQLiteCommand(updateQuery, Main._Connection);
                Main.cmd3.ExecuteNonQuery();
            }
            //btnChange.Hide();
            //btnSave.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (action_btnBack_Clicked != null)
                action_btnBack_Clicked(this, null);
        }

        int tmp;
        int checkSelect;
        private void tableMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Main.flag_admin == true)
            {
                int rowSelected = Convert.ToInt32(tableMatrix.CurrentRow.Index);
                tmp = rowSelected;
                if (tableMatrix.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    //delete database
                    rowSelected = Convert.ToInt32(tableMatrix.CurrentRow.Index);
                    //MessageBox.Show(dataGridView1.SelectedRows[rowSelected].Cells[3].Value.ToString());
                    //MessageBox.Show(dataGridView1.Rows[rowSelected].Cells[2].Value.ToString());
                    MessageBox.Show("Delete");

                    String deleteQuery = "DELETE FROM MaTranKyNang WHERE stt=" + Main.data3.Rows[rowSelected][228].ToString();
                    Console.WriteLine(deleteQuery);
                    SQLiteCommand lpcmd = new SQLiteCommand(deleteQuery, Main._Connection);
                    //Main.cmd2 = new SQLiteCommand(deleteQuery, Main._Connection);
                    //Main.cmd2.ExecuteNonQuery();
                    lpcmd.ExecuteNonQuery();
                    int n = 0;
                    tableMatrix.Rows.RemoveAt(rowSelected);
                    Main.data3.Rows.RemoveAt(rowSelected);
                    //foreach (DataRow item in Main.data3.Rows)
                    //{
                    //    //int n = tableMatrix.Rows.Add();
                    //    for (int i = 0; i <227; i++)
                    //    {
                    //        tableMatrix.Rows[n].Cells[i+2].Value = item["field"+ i].ToString();
                    //        //tableMatrix.Rows[n].Cells[1].Value = item["MaMonHoc"].ToString();
                    //        //tableMatrix.Rows[n].Cells[2].Value = item["TenMonHoc"].ToString();
                    //        //tableMatrix.Rows[n].Cells[3].Value = item["SoTC"].ToString();
                    //        //tableMatrix.Rows[n].Cells[4].Value = item["LT"].ToString();
                    //        //tableMatrix.Rows[n].Cells[5].Value = item["TH"].ToString();
                    //        //tableMatrix.Rows[n].Cells[6].Value = item["BT"].ToString();
                    //        //tableMatrix.Rows[n].Cells[7].Value = item["Loai"].ToString();
                    //        //tableMatrix.Rows[n].Cells[8].Value = item["KeHoach"].ToString();
                            
                    //    }
                    //    n++;

                    //}

                }
                else if (tableMatrix.Columns[e.ColumnIndex].Name.Equals("edit"))
                {
                    MessageBox.Show("Edit");
                    rowSelected = Convert.ToInt32(tableMatrix.CurrentRow.Index);
                    locationEdit.Add(rowSelected);
                    Console.WriteLine(rowSelected);
                    checkSelect = rowSelected;
                    //dataGridView1.ReadOnly = false;
                    tableMatrix.CurrentRow.ReadOnly = false;

                }
                }
            else
            {
                if (tableMatrix.Columns[e.ColumnIndex].Name.Equals("edit") || tableMatrix.Columns[e.ColumnIndex].Name.Equals("delete"))
                {
                    MessageBox.Show("Please login before edit table");
                    if (actionLogin != null)
                        actionLogin(this, null);
                }

            }
            }

        public void loadDataMatrix()
        {

            String sql = "Select * from MaTranKyNang ";
            Main.cmd3 = new SQLiteCommand(sql, Main._Connection);
            Main.cmd3.ExecuteNonQuery();
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(Main.cmd3);
            Main.data3 = new DataTable();
            da2.Fill(Main.data3);

            tableMatrix.DataSource = Main.data3;
            foreach (DataGridViewColumn column in tableMatrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            tableMatrix.Rows[3].DefaultCellStyle.BackColor = Color.Red;
            
            //database hide one columns
            tableMatrix.Columns[230].Visible = false;

            ReadOnlyDataGridView();
        }

        void ReadOnlyDataGridView()
        {
            int countRows = tableMatrix.RowCount;
            for (int i = 0; i < countRows; i++)
            {
                Console.Write("count =" + countRows);
                tableMatrix.Rows[i].ReadOnly = true;
            }
        }
        // xem màu hiện tại để thay đổi khi kich vào hàng đó
        int checkColor = -1;
        void checkLocationSelect(int location)
        {
                if(tableMatrix.Rows[location].DefaultCellStyle.BackColor.Equals(Color.FromArgb(153, 180, 209)))
                    checkColor = 1;
                if (tableMatrix.Rows[location].DefaultCellStyle.BackColor.Equals(Color.FromArgb(164, 214, 224)))
                    checkColor = 2;
        }
        //hiển thị màu hàng khi kich vào
        private void tableMatrix_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            locationRowSeclectPast = locationRowSelectCurrent;
            locationRowSelectCurrent = Convert.ToInt32(tableMatrix.CurrentRow.Index);
            if (!tableMatrix.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                //reset màu của thằng chọn past và hiện màu của thằng chọn current
                if (locationRowSeclectPast != -1)
                {
                    //reset về màu trắng
                    if (checkColor == 1)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);
    
                    }

                    if ( checkColor == 2)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);

                    }
                    if (checkColor == -1)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.White;

                    }
                }
                checkColor = -1;
                checkLocationSelect(locationRowSelectCurrent);
                Console.WriteLine("checkColor = " + checkColor);
                tableMatrix.Rows[locationRowSelectCurrent].DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);
                //mau da bi thay doi
            }
        }

        public void changeColorRow(int index)
        {
            locationRowSeclectPast = locationRowSelectCurrent;
            locationRowSelectCurrent = index;
            
            {
                //reset màu của thằng chọn past và hiện màu của thằng chọn current
                if (locationRowSeclectPast != -1)
                {
                    //reset về màu trắng
                    if (checkColor == 1)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(153, 180, 209);

                    }

                    if (checkColor == 2)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.FromArgb(164, 214, 224);

                    }
                    if (checkColor == -1)
                    {
                        tableMatrix.Rows[locationRowSeclectPast].DefaultCellStyle.BackColor = Color.White;

                    }
                }
                checkColor = -1;
                checkLocationSelect(locationRowSelectCurrent);
                Console.WriteLine("checkColor = " + checkColor);
                tableMatrix.Rows[locationRowSelectCurrent].DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);
                //mau da bi thay doi
            }
        }

        //reset color CĐR bar
        public void resetColorCDRbar()
        {
            for(int i=0;i<=227;i++)
            {
                  tableMatrix.Rows[0].Cells[i].Style.BackColor = Color.FromArgb(0, 232, 58);
            }
        }
     
    }
}
