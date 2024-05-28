using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace burrr
{
    public partial class tabobs : Form
    {

        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "burrr";
        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public tabobs()
        {
            InitializeComponent();
            c();
            t(dataGridView1);
        }
        private void c()
        {
            dataGridView1.Columns.Add("Тип_оборудования", "Тип оборудования");
            dataGridView1.Columns.Add("Вид_обслуживания", "Вид обслуживания");
            dataGridView1.Columns.Add("Стоимость", "Стоимость");
        }
        private void p(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDecimal(2));
        }
        private void t(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Обслуживание";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void tabobs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
