namespace Notes.GUI.sub_forms
{
    partial class sub_note
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_devoir = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.label_devoir = new System.Windows.Forms.Label();
            this.txt_module = new System.Windows.Forms.TextBox();
            this.txt_semestre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label_module = new System.Windows.Forms.Label();
            this.label_semestre = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_add.TabIndex = 44;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_note
            // 
            this.txt_note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_note.Location = new System.Drawing.Point(193, 257);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(335, 20);
            this.txt_note.TabIndex = 42;
            // 
            // txt_devoir
            // 
            this.txt_devoir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_devoir.Location = new System.Drawing.Point(193, 216);
            this.txt_devoir.Name = "txt_devoir";
            this.txt_devoir.Size = new System.Drawing.Size(335, 20);
            this.txt_devoir.TabIndex = 41;
            // 
            // label_note
            // 
            this.label_note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_note.AutoSize = true;
            this.label_note.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note.Location = new System.Drawing.Point(63, 253);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(58, 25);
            this.label_note.TabIndex = 40;
            this.label_note.Text = "Note :";
            // 
            // label_devoir
            // 
            this.label_devoir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_devoir.AutoSize = true;
            this.label_devoir.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devoir.Location = new System.Drawing.Point(63, 212);
            this.label_devoir.Name = "label_devoir";
            this.label_devoir.Size = new System.Drawing.Size(76, 25);
            this.label_devoir.TabIndex = 39;
            this.label_devoir.Text = "Devoir :";
            // 
            // txt_module
            // 
            this.txt_module.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_module.Location = new System.Drawing.Point(193, 173);
            this.txt_module.Name = "txt_module";
            this.txt_module.Size = new System.Drawing.Size(335, 20);
            this.txt_module.TabIndex = 38;
            // 
            // txt_semestre
            // 
            this.txt_semestre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_semestre.Location = new System.Drawing.Point(193, 129);
            this.txt_semestre.Name = "txt_semestre";
            this.txt_semestre.Size = new System.Drawing.Size(335, 20);
            this.txt_semestre.TabIndex = 37;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Location = new System.Drawing.Point(193, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(335, 20);
            this.txt_ID.TabIndex = 36;
            // 
            // label_module
            // 
            this.label_module.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_module.AutoSize = true;
            this.label_module.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_module.Location = new System.Drawing.Point(63, 169);
            this.label_module.Name = "label_module";
            this.label_module.Size = new System.Drawing.Size(82, 25);
            this.label_module.TabIndex = 35;
            this.label_module.Text = "Module :";
            // 
            // label_semestre
            // 
            this.label_semestre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_semestre.AutoSize = true;
            this.label_semestre.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_semestre.Location = new System.Drawing.Point(63, 125);
            this.label_semestre.Name = "label_semestre";
            this.label_semestre.Size = new System.Drawing.Size(89, 25);
            this.label_semestre.TabIndex = 34;
            this.label_semestre.Text = "Semestre :";
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(63, 81);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(120, 25);
            this.label_ID.TabIndex = 33;
            this.label_ID.Text = "ID Etudiant :";
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 51);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(694, 14);
            this.panelBar.TabIndex = 32;
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.panelOptions.Controls.Add(this.btn_Exit);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(694, 51);
            this.panelOptions.TabIndex = 31;
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
            // 
            // sub_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_devoir);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_devoir);
            this.Controls.Add(this.txt_module);
            this.Controls.Add(this.txt_semestre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label_module);
            this.Controls.Add(this.label_semestre);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelOptions);
            this.Name = "sub_note";
            this.Text = "sub_note";
            this.Load += new System.EventHandler(this.sub_note_Load);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_devoir;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_devoir;
        private System.Windows.Forms.TextBox txt_module;
        private System.Windows.Forms.TextBox txt_semestre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label_module;
        private System.Windows.Forms.Label label_semestre;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btn_Exit;
    }
}