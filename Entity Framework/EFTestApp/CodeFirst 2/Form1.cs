using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (UserContext db = new UserContext())
            {
                foreach (var user in db.Users)
                {
                    MessageBox.Show(user.Name);
                }

                db.Users.Add(new User { Id = 4, Name = "Max", Age = 22 });
                db.SaveChanges();
            }
        }
    }
}
