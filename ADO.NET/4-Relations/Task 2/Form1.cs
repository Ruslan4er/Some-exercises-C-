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

namespace Task_2
{
    public partial class Form1 : Form
    {
        private int pageSize = 5;
        private int pageNumber = 0;

        string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=ShopDB; Integrated Security=True";
        private SqlCommandBuilder commandBuilder;

        private SqlDataAdapter adapter;
        private DataSet shopDB;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (var connection = new SqlConnection(conStr))
            {
                shopDB = new DataSet();
                adapter = new SqlDataAdapter(GetSql(), connection);
                adapter.Fill(shopDB, "Customers");
                dataGridView1.DataSource = shopDB.Tables[0];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shopDB.Tables["Customers"].Rows.Count < pageSize) return;

            pageNumber++;
            using (var connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);
                shopDB.Tables["Customers"].Rows.Clear();
                adapter.Fill(shopDB, "Customers");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (pageNumber == 0) return;
            pageNumber--;

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);
                shopDB.Tables["Customers"].Rows.Clear();
                adapter.Fill(shopDB, "Customers");
            }
        }

        private string GetSql()
        {
            return "SELECT * FROM Customers ORDER BY CustomerNo OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                   "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter(GetSql(), connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(shopDB,"Customers");
                MessageBox.Show(commandBuilder.GetUpdateCommand().CommandText);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(conStr))
            {
                adapter = new SqlDataAdapter();
            }
        }
    }
}
