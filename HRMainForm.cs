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
    public partial class HRMainForm : DevExpress.XtraEditors.XtraForm
    {
        private EmpPassword emppass;

        public HRMainForm()
        {
            InitializeComponent();
        }

        public HRMainForm(EmpPassword emppass)
        {
            this.emppass = emppass;
        }

        //Generic
        private void HRMainForm_Load(object sender, EventArgs e)
        {

        }

        private void HRFormOpenButton_Click(object sender, EventArgs e)
        {
            var HRFOpen = new HRForm();
            HRFOpen.ShowDialog();
        }

        private void AttendanceFormOpenButton_Click(object sender, EventArgs e)
        {
            var AFOpen = new AttendanceForm();
            AFOpen.ShowDialog();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void RPMFOpenBtn_Click(object sender, EventArgs e)
        {
            var RPMFOpen = new ReportMainForm();
            RPMFOpen.ShowDialog();
        }
    }
}