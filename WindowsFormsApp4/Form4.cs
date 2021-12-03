using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

       
        string id_rows = "0";

        

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView2.CurrentCell = dataGridView2[e.ColumnIndex, e.RowIndex];

                dataGridView2.CurrentRow.Selected = true;

                string index_rows;

                index_rows = dataGridView2.SelectedCells[0].RowIndex.ToString();

                id_rows = dataGridView2.Rows[Convert.ToInt32(index_rows)].Cells[1].Value.ToString();
                MessageBox.Show(id_rows);
            }
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            Program.con conn = new Program.con();
            MySqlConnection connect = new MySqlConnection(conn.stringconn);
            string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
            try
            {
                connect.Open();
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, connect);

                DataSet dataset = new DataSet();

                IDataAdapter.Fill(dataset);
                dataGridView2.DataSource = dataset.Tables[0];

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                connect.Close();
            }
        }
    }
}