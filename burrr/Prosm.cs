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
    public partial class Prosm : Form
    {
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "burrr";
        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Prosm()
        {
            InitializeComponent();
            c(); d(); b(); a(); o();
            t(dataGridView1);
            u(dataGridView2);
            z(dataGridView3);
            i(dataGridView4);
            n(dataGridView5);
            
        }
        public void c()
        {
            dataGridView1.Columns.Add("Мощность", "Мощность");
            dataGridView1.Columns.Add("Глубина_бурения", "Глубина бурения");
            dataGridView1.Columns.Add("Масса", "Масса");
            dataGridView1.Columns.Add("Цена", "Цена");
        }
        public void d()
        {
            dataGridView2.Columns.Add("Мощность", "Мощность");
            dataGridView2.Columns.Add("Глубина_бурения", "Глубина бурения");
            dataGridView2.Columns.Add("Масса", "Масса");
            dataGridView2.Columns.Add("Цена", "Цена");
        }
        public void b()
        {
            dataGridView3.Columns.Add("Мощность", "Мощность");
            dataGridView3.Columns.Add("Глубина_бурения", "Глубина бурения");
            dataGridView3.Columns.Add("Масса", "Масса");
            dataGridView3.Columns.Add("Цена", "Цена");
        }
        public void a()
        {
            dataGridView4.Columns.Add("Мощность", "Мощность");
            dataGridView4.Columns.Add("Глубина_бурения", "Глубина бурения");
            dataGridView4.Columns.Add("Масса", "Масса");
            dataGridView4.Columns.Add("Цена", "Цена");
        }
        public void o()
        {
            dataGridView5.Columns.Add("Мощность", "Мощность");
            dataGridView5.Columns.Add("Глубина_бурения", "Глубина бурения");
            dataGridView5.Columns.Add("Масса", "Масса");
            dataGridView5.Columns.Add("Цена", "Цена");
        }
        private void p(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3));
        }
        private void t(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Водяные";
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

        private void u(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Горные";
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

        private void z(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Направленные";
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
        private void i(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Поверхностные";
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
        private void n(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Роторные";
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
        private void Prosm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabobs tab = new tabobs();
            tab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
