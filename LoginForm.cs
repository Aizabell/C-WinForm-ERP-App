using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDatabaseTEST
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        HRDBContext dbContext;
        BindingSource dbs;
        EmpPassword _emppass;


        public LoginForm()
        {
            InitializeComponent();
            dbContext = new HRDBContext();
            dbs = new BindingSource();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (dbContext.EmpPasswords.AsNoTracking().Any(a => a.FirstName == UsernameTxt.Text && a.Password == PasswordTxt.Text))
            {
                this.Hide();
                var MainOpen = new HRDocMgr();
                MainOpen.ShowDialog();
                
                /*
                using (var MainOpen = new HRMainForm(_emppass))
                {
                    MainOpen.ShowDialog();
                }
                */
            }
            else
            {
                MessageBox.Show(" Username or Password is incorrect ! ");
            }

        }

        private void FgPwBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}