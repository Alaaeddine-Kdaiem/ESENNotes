using Notes.Entities;
using Notes.GUI.sub_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.GUI.forms
{
    public partial class etudiant : Form
    {
        public static User user;
        public etudiant()
        {
            InitializeComponent();
        }

        public etudiant(User session)
        {
            InitializeComponent();
            user = session;
        }
        private void etudiant_Load(object sender, EventArgs e)
        {

        }

        private Form activeFrom = null;
        private void openForms(Form subForm)
        {
            if (activeFrom != null) activeFrom.Close();
            activeFrom = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(subForm);
            panelForms.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
        }

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Viewnotes_Click(object sender, EventArgs e)
        {
            openForms(new sub_list_etudiant(user.username,user.id));
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            openForms(new sub_about_us());
        }
    }
}
