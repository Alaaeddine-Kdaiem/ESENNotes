namespace Notes.GUI.sub_forms
{
    partial class sub_employe
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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.label_show_hide_ID = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.labelExp = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.panelOptions.Controls.Add(this.btn_Exit);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(694, 51);
            this.panelOptions.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(0, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(51, 51);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 51);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(694, 14);
            this.panelBar.TabIndex = 2;
            // 
            // label_show_hide_ID
            // 
            this.label_show_hide_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_show_hide_ID.AutoSize = true;
            this.label_show_hide_ID.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_hide_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.label_show_hide_ID.Location = new System.Drawing.Point(551, 85);
            this.label_show_hide_ID.Name = "label_show_hide_ID";
            this.label_show_hide_ID.Size = new System.Drawing.Size(100, 25);
            this.label_show_hide_ID.TabIndex = 30;
            this.label_show_hide_ID.Text = "Afficher ID";
            this.label_show_hide_ID.Click += new System.EventHandler(this.label_show_hide_ID_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(395, 393);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 45);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(10)))));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(230, 393);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 45);
            this.btn_edit.TabIndex = 28;
            this.btn_edit.Text = "Modifier";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(68, 393);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 45);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // labelExp
            // 
            this.labelExp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.labelExp.Location = new System.Drawing.Point(63, 307);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(87, 27);
            this.labelExp.TabIndex = 26;
            this.labelExp.Text = "*Support";
            this.labelExp.Click += new System.EventHandler(this.labelExp_Click);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_password.Location = new System.Drawing.Point(193, 257);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(335, 20);
            this.txt_password.TabIndex = 25;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Location = new System.Drawing.Point(193, 216);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(335, 20);
            this.txt_email.TabIndex = 24;
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(63, 253);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(123, 25);
            this.label_password.TabIndex = 23;
            this.label_password.Text = "Mot de passe :";
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(63, 212);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(70, 25);
            this.label_email.TabIndex = 22;
            this.label_email.Text = "Email :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_prenom.Location = new System.Drawing.Point(193, 173);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(335, 20);
            this.txt_prenom.TabIndex = 21;
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nom.Location = new System.Drawing.Point(193, 129);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(335, 20);
            this.txt_nom.TabIndex = 20;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Location = new System.Drawing.Point(193, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(335, 20);
            this.txt_ID.TabIndex = 19;
            // 
            // label_prenom
            // 
            this.label_prenom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.Location = new System.Drawing.Point(63, 169);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(86, 25);
            this.label_prenom.TabIndex = 18;
            this.label_prenom.Text = "Prenom :";
            // 
            // label_nom
            // 
            this.label_nom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(63, 125);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(61, 25);
            this.label_nom.TabIndex = 17;
            this.label_nom.Text = "Nom :";
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(63, 81);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(48, 25);
            this.label_ID.TabIndex = 16;
            this.label_ID.Text = "ID :*";
            // 
            // sub_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.label_show_hide_ID);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelOptions);
            this.Name = "sub_employe";
            this.Text = "sub_employe";
            this.Load += new System.EventHandler(this.sub_employe_Load);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label label_show_hide_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_ID;
    }
}