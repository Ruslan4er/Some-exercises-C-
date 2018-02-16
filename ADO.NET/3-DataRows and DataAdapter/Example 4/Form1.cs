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

namespace Example_4
{
    public partial class Form1 : Form
    {
        private string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.Oders' table. You can move, or remove it, as needed.
            this.odersTableAdapter.Fill(this.universityDataSet.Oders);
            //using (var connenction = new SqlConnection(conStr))
            //{
            //    DataSet ds = new DataSet(); 
            //    var adapter = new SqlDataAdapter("SELECT Oders.id,Users.name,Oders.cost FROM Oders JOIN Users ON Oders.user_id=Users.id", conStr);
            //    adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];

            //}
        }



    }
}
