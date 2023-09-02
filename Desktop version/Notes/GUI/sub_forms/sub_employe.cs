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

namespace Notes.GUI.sub_forms
{
    public partial class sub_employe : Form
    {
        public sub_employe()
        {
            InitializeComponent();
            txt_ID.Hide();
            label_ID.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sub_employe_Load(object sender, EventArgs e)
        {

        }

        private void label_show_hide_ID_Click(object sender, EventArgs e)
        {
            if (label_show_hide_ID.Text == "Afficher ID")
            {
                txt_ID.Show();
                label_ID.Show();
                label_show_hide_ID.Text = "Masquer ID";
            }
            else
            {
                txt_ID.Hide();
                label_ID.Hide();
                label_show_hide_ID.Text = "Afficher ID";
            }
        }

        private void labelExp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si vous souhaitez modifier ou supprimer l'admin cliquer sur Afficher ID et donnez l'identifiant ", "Support", MessageBoxButtons.OK);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                if ((txt_nom.Text != "") && (txt_prenom.Text != "") && (txt_email.Text != "") && (txt_password.Text != ""))
                {

                    Commands cmd = new Commands();
                    if (!cmd.FindUserByEmail(txt_email.Text))
                    {
                        User user = new User(txt_prenom.Text, txt_email.Text, txt_password.Text, 1);
                        Employe employe = new Employe(txt_nom.Text, txt_prenom.Text);
                        cmd.AddUser(user);
                        User id_user = cmd.GetUserByEmail(txt_email.Text);
                        employe.id_user = id_user.id;

                        if (cmd.AddEmploye(employe))
                        {
                            MessageBox.Show("Employe créer avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employe n'est pas crée!", "ATTENTION",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email existe déjà, veuillez en remplir un autre !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("veuillez remplir tous les champs sauf le champ ID !", "ATTENTION",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez ne pas remplir le champ ID !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ((txt_ID.Text != "") && (txt_nom.Text != "") && (txt_prenom.Text != "") && (txt_email.Text != "") && (txt_password.Text != ""))
            {
                Commands cmd = new Commands();
                try
                {
                    int val = Int32.Parse(txt_ID.Text);


                    if (val > 0)
                    {
                        Employe old_employe = cmd.GetEmployeById(val);
                        User user = new User(old_employe.id_user, txt_prenom.Text, txt_email.Text, txt_password.Text);
                        Employe new_employe = new Employe(old_employe.id, txt_nom.Text, txt_prenom.Text);

                        if (cmd.EditEmploye(new_employe) && cmd.EditUser(user))
                        {
                            MessageBox.Show("Employe modifier avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employe n'existe pas!", "ATTENTION",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir le champ ID avec un nombre positive", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID introuvable !,veuillez remplir le champ ID avec un autre nombre", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir tous les champs !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                if ((txt_nom.Text != "") || (txt_prenom.Text != "") || (txt_email.Text != "") || (txt_password.Text != ""))
                {
                    MessageBox.Show("Il suffit de remplir uniquement le champ ID.", "SUCCES",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Commands cmd = new Commands();
                try
                {
                    int val = Int32.Parse(txt_ID.Text);


                    if (val > 0)
                    {
                        Employe employe = cmd.GetEmployeById(val);
                        User user = new User();
                        user.id = employe.id_user;

                        if (cmd.DeleteEmploye(employe) && cmd.DeleteUser(user))
                        {
                            MessageBox.Show("Employe supprimer avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employe n'existe pas!", "ATTENTION",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir le champ ID avec un nombre positive", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("veuillez remplir le champ ID avec un nombre correct", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir le champ ID !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
