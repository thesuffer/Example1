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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            work_place();
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost; Integrated Security=SSPI; Initial Catalog=Digital_signatures;");
            // return new SqlConnection("Data Source=WIN-N3AAFBCNFK0/SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=Digital_signatures;Integrated Security = true;");
        }

        SqlConnection connection = GetConnection();
        SqlDataAdapter adapter;

        void work_place()
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            adapter = new SqlDataAdapter("select employee_respons_id as Код_ответственного_сотрудника, e.name as Сотрудники, e.phone_number as Номер_телефона, e.post as Должность from work_place w join employee e on w.employee_id=e.employee_id;", connection);
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
            work_place();
        }
    }
}
