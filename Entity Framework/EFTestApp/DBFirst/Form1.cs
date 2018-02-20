using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (userstoredbEntities db = new userstoredbEntities())
            {
                //db.Users.Add(new User() {Age = 22, Id = 3, Name = "Antony"});
                //db.SaveChanges();

                dataGridView1.DataSource = db.Users.ToList();
                dataGridView1.Columns[0].Visible = false;
            }
        }
    }
}
