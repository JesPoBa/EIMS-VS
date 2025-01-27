﻿namespace WindowsFormsApp1
{
    partial class frm_Settings
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.appData = new WindowsFormsApp1.AppData();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ChangeProfilePicture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adduseradmin = new System.Windows.Forms.GroupBox();
            this.dgv_adminuser = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.tbllogTableAdapter = new WindowsFormsApp1.AppDataTableAdapters.tbllogTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            this.adduseradmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_ChangeProfilePicture);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox_ProfilePicture);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(865, 343);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Settings";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appData, "tbllog.Username", true));
            this.label_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Username.Location = new System.Drawing.Point(142, 211);
            this.label_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(150, 18);
            this.label_Username.TabIndex = 9;
            this.label_Username.Text = "currentUsername";
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(142, 239);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Change Password";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // btn_ChangeProfilePicture
            // 
            this.btn_ChangeProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.btn_ChangeProfilePicture.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeProfilePicture.Image = global::WindowsFormsApp1.Properties.Resources.change_profile_24;
            this.btn_ChangeProfilePicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeProfilePicture.Location = new System.Drawing.Point(226, 99);
            this.btn_ChangeProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChangeProfilePicture.Name = "btn_ChangeProfilePicture";
            this.btn_ChangeProfilePicture.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ChangeProfilePicture.Size = new System.Drawing.Size(184, 28);
            this.btn_ChangeProfilePicture.TabIndex = 6;
            this.btn_ChangeProfilePicture.Text = "     Change Profile Picture";
            this.btn_ChangeProfilePicture.UseVisualStyleBackColor = false;
            this.btn_ChangeProfilePicture.Click += new System.EventHandler(this.btn_ChangeProfilePicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Profile Picture";
            // 
            // pictureBox_ProfilePicture
            // 
            this.pictureBox_ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ProfilePicture.Image = global::WindowsFormsApp1.Properties.Resources.profile_icon_64;
            this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(62, 61);
            this.pictureBox_ProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
            this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(131, 114);
            this.pictureBox_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ProfilePicture.TabIndex = 4;
            this.pictureBox_ProfilePicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.appData;
            // 
            // adduseradmin
            // 
            this.adduseradmin.Controls.Add(this.dgv_adminuser);
            this.adduseradmin.Controls.Add(this.label11);
            this.adduseradmin.Controls.Add(this.label10);
            this.adduseradmin.Controls.Add(this.label8);
            this.adduseradmin.Controls.Add(this.cb_role);
            this.adduseradmin.Controls.Add(this.txt_password);
            this.adduseradmin.Controls.Add(this.txt_userName);
            this.adduseradmin.Controls.Add(this.btn_cancel);
            this.adduseradmin.Controls.Add(this.btn_delete);
            this.adduseradmin.Controls.Add(this.btn_save);
            this.adduseradmin.Controls.Add(this.btn_edit);
            this.adduseradmin.Controls.Add(this.btn_new);
            this.adduseradmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduseradmin.Location = new System.Drawing.Point(25, 397);
            this.adduseradmin.Margin = new System.Windows.Forms.Padding(2);
            this.adduseradmin.Name = "adduseradmin";
            this.adduseradmin.Padding = new System.Windows.Forms.Padding(2);
            this.adduseradmin.Size = new System.Drawing.Size(865, 343);
            this.adduseradmin.TabIndex = 6;
            this.adduseradmin.TabStop = false;
            this.adduseradmin.Text = "Add User/Admin";
            // 
            // dgv_adminuser
            // 
            this.dgv_adminuser.AutoGenerateColumns = false;
            this.dgv_adminuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adminuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgv_adminuser.DataSource = this.tbllogBindingSource;
            this.dgv_adminuser.Location = new System.Drawing.Point(486, 32);
            this.dgv_adminuser.Name = "dgv_adminuser";
            this.dgv_adminuser.RowHeadersWidth = 51;
            this.dgv_adminuser.Size = new System.Drawing.Size(344, 286);
            this.dgv_adminuser.TabIndex = 8;
            this.dgv_adminuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adminuser_CellContentClick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(28, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(28, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(28, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Username";
            // 
            // cb_role
            // 
            this.cb_role.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbllogBindingSource, "Role", true));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cb_role.Location = new System.Drawing.Point(32, 190);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(161, 29);
            this.cb_role.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(32, 127);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(291, 29);
            this.txt_password.TabIndex = 5;
            // 
            // txt_userName
            // 
            this.txt_userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "Username", true));
            this.txt_userName.Location = new System.Drawing.Point(32, 56);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(291, 29);
            this.txt_userName.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(361, 237);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 32);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(361, 192);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(104, 32);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(361, 147);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 32);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(361, 101);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 32);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(361, 54);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(104, 32);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "Create New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 768);
            this.Controls.Add(this.adduseradmin);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1238, 768);
            this.Name = "frm_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            this.adduseradmin.ResumeLayout(false);
            this.adduseradmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adminuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ChangeProfilePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_ProfilePicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.GroupBox adduseradmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_adminuser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AppDataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}