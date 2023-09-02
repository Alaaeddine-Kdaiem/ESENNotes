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
    public partial class sub_semestre : Form
    {
        public sub_semestre()
        {
            InitializeComponent();
            txt_ID.Hide();
            label_ID.Hide();
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

        private void sub_semestre_Load(object sender, EventArgs e)
        {

        }

        private void labelExp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si vous souhaitez modifier ou supprimer la semestre cliquer sur Afficher ID et donnez l'identifiant ", "Support", MessageBoxButtons.OK);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                if (txt_semestre.Text != "")
                {
                    Commands cmd = new Commands();
                    Semestre semestre = new Semestre();
                    semestre.semestre = txt_semestre.Text;

                    if (cmd.AddSemestre(semestre))
                    {
                        MessageBox.Show("Semestre créer avec succes.", "SUCCES",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Semestre n'est pas crée!", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("veuillez remplir le champ Semestre !", "ATTENTION",
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
                if (txt_semestre.Text != "")
                {
                    Commands cmd = new Commands();
                    try
                    {
                        int val = Int32.Parse(txt_ID.Text);

                        if (val > 0)
                        {
                            Semestre semestre = new Semestre(val, txt_semestre.Text);

                            if (cmd.EditSemestre(semestre))
                            {
                                MessageBox.Show("Semestre modifier avec succes.", "SUCCES",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Semestre n'existe pas!", "ATTENTION",
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
                    MessageBox.Show("veuillez remplir le champ Semestre !", "ATTENTION",
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
                        Semestre semestre = new Semestre();
                        semestre.id = val;

                        if (cmd.DeleteSemestre(semestre))
                        {
                            MessageBox.Show("Semestre supprimer avec succes.", "SUCCES",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Semestre n'existe pas!", "ATTENTION",
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
