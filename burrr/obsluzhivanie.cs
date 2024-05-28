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
    public partial class obsluzhivanie : Form
    {
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\logs" + @"\logs.txt";
        string type = "";
        string vid = "";
        decimal stoim;
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "burrr";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public obsluzhivanie()
        {
            InitializeComponent();
        }

        private void obsluzhivanie_Load(object sender, EventArgs e)
        {

        }
        public void Upd(string labelText)
        {
            label1.Text = labelText;

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label3.Text) == 0)
            {
                MessageBox.Show("Выберите варианты обслуживания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var selectedItems = checkedListBox1.CheckedItems.Cast<string>().ToArray();
                type = label1.Text;
                vid = string.Join(", ", selectedItems);
                stoim = Convert.ToDecimal(label3.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable Table = new DataTable();
                string quere = $"select * from Обслуживание";
                SqlCommand cmd = new SqlCommand(quere, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(Table);
                con.Open();
                SqlCommand insertCommand = new SqlCommand($"insert into Обслуживание(Тип_оборудования, Вид_обслуживания, Стоимость) values ('{type}','{vid}','{stoim}')", con);
                if (insertCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Обслуживание заказано!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void summ()
        {
            double стоимость = 0;
            foreach (string d in checkedListBox1.CheckedItems)
                switch (d)
                {
                    case "Техосмотр":
                        стоимость += 5000;
                        break;
                    case "Замена масла":
                        стоимость += 3000;
                        break;
                    case "Ремонт двигателя":
                        стоимость += 20000;
                        break;
                    case "Замена системы охлаждения":
                        стоимость += 10000;
                        break;
                    case "Заправка топлива":
                        стоимость += 7500;
                        break;
                    case "Замена лебёдки":
                        стоимость += 2000;
                        break;
                    case "Замена проводки":
                        стоимость += 15000;
                        break;
                }
            double kom = стоимость * 1.1;
            label3.Text = $"{kom.ToString()} ";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            summ();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
