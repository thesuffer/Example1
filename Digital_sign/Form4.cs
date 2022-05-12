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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            employee();
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost; Integrated Security=SSPI; Initial Catalog=Digital_signatures;");
            // return new SqlConnection("Data Source=WIN-N3AAFBCNFK0/SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=Digital_signatures;Integrated Security = true;");
        }

        SqlConnection connection = GetConnection();
        SqlDataAdapter adapter;

        void employee()
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select sign_id as Код_ЭЦП, sign_ago_id as Код_ЭЦП_с_истекшим_сроком, d.depart_name as Отдел, name as ФИО, post as Должность, phone_number as Номер_телефона from employee e join depart d on e.depart_id=d.depart_id;", connection);
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
            employee();
        }
    }
}
