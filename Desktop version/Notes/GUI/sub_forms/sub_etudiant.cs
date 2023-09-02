using Notes.Config;
using Notes.Entities;
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

namespace Notes.GUI.sub_forms
{
    public partial class sub_etudiant : Form
    {
        public sub_etudiant()
        {
            InitializeComponent();
            txt_ID.Hide();
            label_ID.Hide();
        }

        private void sub_etudiant_Load(object sender, EventArgs e)
        {

        }

        private void labelExp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si vous souhaitez modifier ou supprimer l'admin cliquer sur Afficher ID et donnez l'identifiant ", "Support", MessageBoxButtons.OK);

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                if ((txt_nom.Text != "") && (txt_prenom.Text != "") && (txt_email.Text != "") && (txt_password.Text != "") && (txt_filiere.Text!= "") && (txt_classe.Text!= ""))
                {
                    Commands cmd = new Commands();
                    if (!cmd.FindUserByEmail(txt_email.Text))
                    {
                        Filiere f = cmd.GetFiliereByName(txt_filiere.Text);
                        Classe c = cmd.GetClasseByName(txt_classe.Text);
                        if (f != null)
                        {
                            if (c != null)
                            {
                                Etudiant etudiant = new Etudiant(txt_nom.Text, txt_prenom.Text, f.id, c.id);
                                User user = new User(txt_prenom.Text, txt_email.Text, txt_password.Text, 3);
                                cmd.AddUser(user);
                                User id_user = cmd.GetUserByEmail(txt_email.Text);
                                etudiant.id_user = id_user.id;
                                if (cmd.AddEtudiant(etudiant))
                                {
                                    MessageBox.Show("Etudiant créer avec succes.", "SUCCES",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Etudiant n'est pas crée!", "ATTENTION",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Classe introuvable, veuillez saisir un autre classe !", "ATTENTION",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Filiere introuvable, veuillez saisir une autre filiere !", "ATTENTION",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email existe déjà, veuillez saisir un autre !", "ATTENTION",
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
            if ((txt_ID.Text != "") && (txt_nom.Text != "") && (txt_prenom.Text != "") && (txt_email.Text != "") && (txt_password.Text != "") && (txt_filiere.Text != "") && (txt_filiere.Text != ""))
            {
                Commands cmd = new Commands();
                Filiere f = cmd.GetFiliereByName(txt_filiere.Text);
                Classe c = cmd.GetClasseByName(txt_classe.Text);
                if (f != null)
                {
                    if (c != null)
                    {
                        try
                        {
                            int val = Int32.Parse(txt_ID.Text);

                            if (val > 0)
                            {

                                Etudiant old_etudiant = cmd.GetEtudiantById(val);
                                User user = new User(old_etudiant.id_user, txt_prenom.Text, txt_email.Text, txt_password.Text);
                                Etudiant new_etudiant = new Etudiant(old_etudiant.id, txt_nom.Text, txt_prenom.Text, f.id, c.id);

                                if (cmd.EditEtudiant(new_etudiant) && cmd.EditUser(user))
                                {
                                    MessageBox.Show("Etudiant modifier avec succes.", "SUCCES",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Etudiant n'existe pas!", "ATTENTION",
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
                            MessageBox.Show("ID introuvable, veuillez remplir le champ ID avec un autre nombre !", "ATTENTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Classe introuvable, veuillez saisir un autre classe !", "ATTENTION",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Filiere introuvable, veuillez saisir une autre filiere !", "ATTENTION",
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
                if ((txt_nom.Text != "") || (txt_prenom.Text != "") || (txt_email.Text != "") || (txt_password.Text != "") || (txt_filiere.Text != "") || (txt_classe.Text != ""))
                {
                    MessageBox.Show("Il suffit de remplir uniquement le champ ID.", "SUPPORT",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Commands cmd = new Commands();
                try
                {
                    int val = Int32.Parse(txt_ID.Text);


                    if (val > 0)
                    {
                        Etudiant etudiant = cmd.GetEtudiantById(val);
                        User user = new User();
                        user.id = etudiant.id_user;

                        if (cmd.DeleteEtudiant(etudiant) && cmd.DeleteUser(user))
                        {
                            MessageBox.Show("Etudiant supprimer avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Etudiant n'existe pas!", "ATTENTION",
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
                    MessageBox.Show("ID introuvable, veuillez saisir une autre ID !", "ATTENTION",
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
