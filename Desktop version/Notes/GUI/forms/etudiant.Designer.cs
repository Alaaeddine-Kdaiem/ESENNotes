namespace Notes.GUI.forms
{
    partial class etudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etudiant));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.btn_Viewnotes = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.btn_deconnect);
            this.panelMenu.Controls.Add(this.btn_Viewnotes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 561);
            this.panelMenu.TabIndex = 1;
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
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // btn_Viewnotes
            // 
            this.btn_Viewnotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Viewnotes.FlatAppearance.BorderSize = 0;
            this.btn_Viewnotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Viewnotes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Viewnotes.Location = new System.Drawing.Point(0, 100);
            this.btn_Viewnotes.Name = "btn_Viewnotes";
            this.btn_Viewnotes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Viewnotes.Size = new System.Drawing.Size(240, 45);
            this.btn_Viewnotes.TabIndex = 6;
            this.btn_Viewnotes.Text = "Notes";
            this.btn_Viewnotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Viewnotes.UseVisualStyleBackColor = true;
            this.btn_Viewnotes.Click += new System.EventHandler(this.btn_Viewnotes_Click);
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
            this.panelCredit.TabIndex = 2;
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
            this.panelForms.TabIndex = 3;
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
            // etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelCredit);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "etudiant";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.Load += new System.EventHandler(this.etudiant_Load);
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
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.Button btn_Viewnotes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelCredit;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_about;
    }
}