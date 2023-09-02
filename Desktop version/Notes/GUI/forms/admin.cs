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
    public partial class admin : Form
    {
        public static User user;
        public admin()
        {
            InitializeComponent();
        }
        public admin(User session)
        {
            InitializeComponent();
            user = session;
        }
        private void admin_Load(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            openForms(new sub_list_admin());
        }

        private void btn_admins_Click(object sender, EventArgs e)
        {
            openForms(new sub_admin());
        }

        private void btn_classes_Click(object sender, EventArgs e)
        {
            openForms(new sub_classe());
        }

        private void btn_filieres_Click(object sender, EventArgs e)
        {
            openForms(new sub_filiere());
        }

        private void btn_employes_Click(object sender, EventArgs e)
        {
            openForms(new sub_employe());
        }

        private void btn_devoirs_Click(object sender, EventArgs e)
        {
            openForms(new sub_devoir());
        }

        private void btn_modules_Click(object sender, EventArgs e)
        {
            openForms(new sub_module());
        }

        private void btn_semestres_Click(object sender, EventArgs e)
        {
            openForms(new sub_semestre());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeFrom != null) activeFrom.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            openForms(new sub_about_us());
        }
    }
}
