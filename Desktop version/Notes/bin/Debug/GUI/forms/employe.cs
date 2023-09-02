using Notes.Entities;
using Notes.Config;
using Notes.GUI.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.GUI.sub_forms;

namespace Notes.GUI.forms
{
    public partial class employe : Form
    {
        public static User user;
        
        public employe()
        {
            InitializeComponent();
        }

         public employe(User session)
        {
            InitializeComponent();
            user = session;
        }

        private void btn_delete_etudiant_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_etudiant_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_etudiant_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employe_Load(object sender, EventArgs e)
        {

        }

        private void panelForms_Paint(object sender, EventArgs e)
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

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            openForms(new sub_list_employe());
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            openForms(new sub_about_us());
        }

        private void btn_etudiants_Click(object sender, EventArgs e)
        {
            openForms(new sub_etudiant());
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            openForms(new sub_note());
        }
    }
}
