using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace burrr
{
    public partial class Poverh : Form
    {
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\logs" + @"\logs.txt";
        int moch;
        int glub;
        int mass;
        decimal stoim;
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "burrr";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Poverh()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            obsluzhivanie obs = new obsluzhivanie();
            obs.Upd("Поверхностные буровые установки");
            obs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Мощность = double.Parse(textBox2.Text);
            if (Мощность < 110 || Мощность > 168)
            {
                MessageBox.Show("Мощность должна быть в диапазоне от 110 до 168 кВт.");
                return;
            }
            double Глубина = double.Parse(textBox1.Text);
            if (Глубина < 10 || Глубина > 25)
            {
                MessageBox.Show("Глубина должна быть в диапазоне от 10 до 25 метров.");
                return;
            }
            double Масса = double.Parse(textBox3.Text);
            if (Масса < 11000 || Масса > 15000)
            {
                MessageBox.Show("Масса должна быть в диапазоне от 11000 до 15000 кг.");
                return;
            }

            moch = Convert.ToInt32(textBox1.Text);
            glub = Convert.ToInt32(textBox2.Text);
            mass = Convert.ToInt32(textBox3.Text);
            stoim = Convert.ToDecimal(textBox4.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            string quere = $"select * from Поверхностные";
            SqlCommand cmd = new SqlCommand(quere, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(Table);
            con.Open();
            SqlCommand insertCommand = new SqlCommand($"insert into Поверхностные(Мощность, Глубина_бурения, Масса, Цена) values ('{moch}','{glub}','{mass}','{stoim}')", con);
            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Оборудование успешно добавлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "0";
            }
        }
    }
}
