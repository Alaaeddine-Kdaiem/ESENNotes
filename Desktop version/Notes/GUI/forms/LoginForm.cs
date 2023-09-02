using Notes.Config;
using Notes.Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Commands command = new Commands();
            User session = command.Exist(new Login(tb_email.Text, tb_password.Text));
            if (session != null)
            {
                switch(session.role)
                {
                    case 1:
                     // MessageBox.Show(session.toString());
                        new employe(session).Show();
                        this.Dispose(false);
                        break;
                    case 2:
                     // MessageBox.Show(session.toString());
                        new admin(session).Show();
                        this.Dispose(false);
                        break;
                    case 3:
                     // MessageBox.Show(session.toString());
                        new etudiant(session).Show();
                        this.Dispose(false);
                        break;
                }
                
            }
            else
                MessageBox.Show("Utilisateur non trouvé.\n\nEmail d'utilisateur/Mot de passe incorrect."
                               , "Authentification"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Stop);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            tb_email.Text = "";
            tb_password.Text = "";
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
