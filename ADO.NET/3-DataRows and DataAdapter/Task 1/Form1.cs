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

namespace Task_1
{
    public partial class Form1 : Form
    {
        private string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
        private DataSet usersDataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(conStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);

                adapter.Fill(usersDataSet);
                dataGridView1.DataSource = usersDataSet.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet changedUserDataSet = usersDataSet.Copy();

            for (int i = 0; i < usersDataSet.Tables[0].Rows.Count; i++)
            {
                if (changedUserDataSet.Tables[0].Rows[i].RowState == DataRowState.Unchanged)
                    changedUserDataSet.Tables[0].Rows[i].Delete();
            }

            dataGridView2.DataSource = changedUserDataSet.Tables[0];
        }
    }
}
