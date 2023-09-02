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
    public partial class sub_filiere : Form
    {
        public sub_filiere()
        {
            InitializeComponent();
            txt_ID.Hide();
            label_ID.Hide();
        }

        private void sub_filiere_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

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
            MessageBox.Show("Si vous souhaitez modifier ou supprimer le filiere cliquer sur Afficher ID et donnez l'identifiant ", "Support", MessageBoxButtons.OK);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                if (txt_filiere.Text != "")
                {
                    Commands cmd = new Commands();
                    Filiere filiere = new Filiere();
                    filiere.filiere = txt_filiere.Text;

                    if (cmd.AddFiliere(filiere))
                    {
                        MessageBox.Show("Filiere créer avec succes.", "SUCCES",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Filiere n'est pas crée!", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("veuillez remplir le champ Filiere !", "ATTENTION",
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
            if (txt_ID.Text != "")
            {
                if (txt_filiere.Text != "")
                {
                    Commands cmd = new Commands();
                    try
                    {
                        int val = Int32.Parse(txt_ID.Text);

                        if (val > 0)
                        {
                            Filiere filiere = new Filiere(val, txt_filiere.Text);

                            if (cmd.EditFiliere(filiere))
                            {
                                MessageBox.Show("Filiere modifier avec succes.", "SUCCES",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Filiere n'existe pas!", "ATTENTION",
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
                    MessageBox.Show("veuillez remplir le champ Filiere !", "ATTENTION",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir le champ ID !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                Commands cmd = new Commands();
                try
                {
                    int val = Int32.Parse(txt_ID.Text);

                    if (val > 0)
                    {
                        Filiere filiere = new Filiere();
                        filiere.id = val;

                        if (cmd.DeleteFiliere(filiere))
                        {
                            MessageBox.Show("Filiere supprimer avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Filiere n'existe pas!", "ATTENTION",
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
