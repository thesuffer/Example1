using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_sign
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            sign_ago();
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost; Integrated Security=SSPI; Initial Catalog=Digital_signatures;");
            // return new SqlConnection("Data Source=WIN-N3AAFBCNFK0/SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=Digital_signatures;Integrated Security = true;");
        }

        SqlConnection connection = GetConnection();
        SqlDataAdapter adapter;

        void sign_ago()
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select e.name as ФИО_сотрудника, sign_ago_count as Количество_ЭЦП_с_истекшим_сроком, sign_ago_time_in_sys as Срок_хранения_в_системе_до, sign_ago_time_start as Начало_действия_ЭЦП, sign_ago_time_end as Конец_действия_ЭЦП from sign_ago s join employee e on s.employee_id=s.employee_id;", connection);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            //this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sign_ago();
        }
    }
}
