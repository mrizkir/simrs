namespace simrs.Setting
{
    partial class FrmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.rdLaki = new System.Windows.Forms.RadioButton();
            this.rdPerempuan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUserPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDefaultRole = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNomorHP = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNamaLengkap = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTempatLahir = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNomorHP = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDefaultRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNomorHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNamaLengkap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTempatLahir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgUsers.Location = new System.Drawing.Point(0, 362);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 24;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(1054, 218);
            this.dgUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEFAULT ROLE";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(175, 111);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(282, 32);
            this.cmbRoles.TabIndex = 2;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(175, 279);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(158, 44);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rdLaki
            // 
            this.rdLaki.AutoSize = true;
            this.rdLaki.Checked = true;
            this.rdLaki.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLaki.Location = new System.Drawing.Point(681, 67);
            this.rdLaki.Name = "rdLaki";
            this.rdLaki.Size = new System.Drawing.Size(118, 28);
            this.rdLaki.TabIndex = 6;
            this.rdLaki.TabStop = true;
            this.rdLaki.Text = "LAKI - LAKI";
            this.rdLaki.UseVisualStyleBackColor = true;
            // 
            // rdPerempuan
            // 
            this.rdPerempuan.AutoSize = true;
            this.rdPerempuan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPerempuan.Location = new System.Drawing.Point(805, 65);
            this.rdPerempuan.Name = "rdPerempuan";
            this.rdPerempuan.Size = new System.Drawing.Size(137, 28);
            this.rdPerempuan.TabIndex = 7;
            this.rdPerempuan.Text = "PEREMPUAN";
            this.rdPerempuan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "JENIS KELAMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "USER NAME";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.Location = new System.Drawing.Point(175, 63);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '#';
            this.txtUserPassword.Size = new System.Drawing.Size(282, 30);
            this.txtUserPassword.TabIndex = 1;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "PASSWORD";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaLengkap.Location = new System.Drawing.Point(675, 15);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(304, 30);
            this.txtNamaLengkap.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "NAMA LENGKAP";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "EMAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "NOMOR HP";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahir.Location = new System.Drawing.Point(675, 119);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(304, 30);
            this.txtTempatLahir.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "TEMPAT LAHIR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "TANGGAL LAHIR";
            // 
            // dtTanggalLahir
            // 
            this.dtTanggalLahir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggalLahir.Location = new System.Drawing.Point(675, 160);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(304, 30);
            this.dtTanggalLahir.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtNomorHP);
            this.panel1.Controls.Add(this.dtTanggalLahir);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTempatLahir);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNamaLengkap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdPerempuan);
            this.panel1.Controls.Add(this.rdLaki);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 356);
            this.panel1.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(175, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(282, 30);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epUserPassword
            // 
            this.epUserPassword.ContainerControl = this;
            // 
            // epDefaultRole
            // 
            this.epDefaultRole.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epNomorHP
            // 
            this.epNomorHP.ContainerControl = this;
            // 
            // epNamaLengkap
            // 
            this.epNamaLengkap.ContainerControl = this;
            // 
            // epTempatLahir
            // 
            this.epTempatLahir.ContainerControl = this;
            // 
            // txtNomorHP
            // 
            this.txtNomorHP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomorHP.Location = new System.Drawing.Point(175, 207);
            this.txtNomorHP.Mask = "0000-00000000";
            this.txtNomorHP.Name = "txtNomorHP";
            this.txtNomorHP.Size = new System.Drawing.Size(282, 30);
            this.txtNomorHP.TabIndex = 20;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 580);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USERS";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDefaultRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNomorHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNamaLengkap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTempatLahir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.RadioButton rdLaki;
        private System.Windows.Forms.RadioButton rdPerempuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTanggalLahir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epUserPassword;
        private System.Windows.Forms.ErrorProvider epDefaultRole;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epNomorHP;
        private System.Windows.Forms.ErrorProvider epNamaLengkap;
        private System.Windows.Forms.ErrorProvider epTempatLahir;
        private System.Windows.Forms.MaskedTextBox txtNomorHP;
    }
}