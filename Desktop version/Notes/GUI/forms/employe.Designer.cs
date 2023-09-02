namespace Notes.GUI.forms
{
    partial class employe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employe));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.btn_notes = new System.Windows.Forms.Button();
            this.btn_etudiants = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCredit = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCredit.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelMenu.Controls.Add(this.btn_view);
            this.panelMenu.Controls.Add(this.btn_deconnect);
            this.panelMenu.Controls.Add(this.btn_notes);
            this.panelMenu.Controls.Add(this.btn_etudiants);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_view.FlatAppearance.BorderSize = 0;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_view.Location = new System.Drawing.Point(0, 190);
            this.btn_view.Name = "btn_view";
            this.btn_view.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_view.Size = new System.Drawing.Size(240, 45);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "Listes";
            this.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_deconnect.FlatAppearance.BorderSize = 0;
            this.btn_deconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deconnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deconnect.Location = new System.Drawing.Point(0, 516);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_deconnect.Size = new System.Drawing.Size(240, 45);
            this.btn_deconnect.TabIndex = 10;
            this.btn_deconnect.Text = "Deconnecté";
            this.btn_deconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_notes
            // 
            this.btn_notes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_notes.FlatAppearance.BorderSize = 0;
            this.btn_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_notes.Location = new System.Drawing.Point(0, 145);
            this.btn_notes.Name = "btn_notes";
            this.btn_notes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_notes.Size = new System.Drawing.Size(240, 45);
            this.btn_notes.TabIndex = 6;
            this.btn_notes.Text = "Notes";
            this.btn_notes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_notes.UseVisualStyleBackColor = true;
            this.btn_notes.Click += new System.EventHandler(this.btn_notes_Click);
            // 
            // btn_etudiants
            // 
            this.btn_etudiants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_etudiants.FlatAppearance.BorderSize = 0;
            this.btn_etudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_etudiants.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_etudiants.Location = new System.Drawing.Point(0, 100);
            this.btn_etudiants.Name = "btn_etudiants";
            this.btn_etudiants.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_etudiants.Size = new System.Drawing.Size(240, 45);
            this.btn_etudiants.TabIndex = 1;
            this.btn_etudiants.Text = "Etudiants";
            this.btn_etudiants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_etudiants.UseVisualStyleBackColor = true;
            this.btn_etudiants.Click += new System.EventHandler(this.btn_etudiants_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notes.Properties.Resources.logo1_clear;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelCredit
            // 
            this.panelCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelCredit.Controls.Add(this.btn_about);
            this.panelCredit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCredit.Location = new System.Drawing.Point(240, 516);
            this.panelCredit.Name = "panelCredit";
            this.panelCredit.Size = new System.Drawing.Size(694, 45);
            this.panelCredit.TabIndex = 1;
            // 
            // btn_about
            // 
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_about.Location = new System.Drawing.Point(553, 0);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(141, 45);
            this.btn_about.TabIndex = 5;
            this.btn_about.Text = "A propos de nous";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelForms.Controls.Add(this.pictureBox3);
            this.panelForms.Controls.Add(this.pictureBox2);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(240, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(694, 516);
            this.panelForms.TabIndex = 2;
            this.panelForms.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForms_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Notes.Properties.Resources.quote;
            this.pictureBox3.Location = new System.Drawing.Point(417, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Notes.Properties.Resources.logo1_clear;
            this.pictureBox2.Location = new System.Drawing.Point(110, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelCredit);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "employe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.Load += new System.EventHandler(this.employe_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCredit.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_etudiants;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.Button btn_notes;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Panel panelCredit;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_about;
    }
}