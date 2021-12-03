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
using conector;
namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 Class1 conn = new Class1();
                MySqlConnection connn = new MySqlConnection(conn.stringconn);
                string fioStud = textBox2.Text;
                string time = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
                MessageBox.Show(time);
                string timeStud = textBox1.Text == "" ? time : textBox1.Text;
                string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fioStud}','{timeStud}');";
                int counter = 0;
            try
            {
                    connn.Open();

                    MySqlCommand command1 = new MySqlCommand(sql, connn);
                    counter = command1.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("ошибка");
                }
                finally
                {
                    connn.Close();
                    if (counter != 0)
                    {
                        MessageBox.Show("успешно");
                    }
                }
            
        }
    }
}
