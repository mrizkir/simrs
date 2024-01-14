namespace simrs
{
    partial class FrmUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROFILEToolStripMenuItem,
            this.menuSettingUsers});
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(80, 24);
            this.menuSetting.Text = "SETTING";
            // 
            // menuSettingUsers
            // 
            this.menuSettingUsers.Name = "menuSettingUsers";
            this.menuSettingUsers.Size = new System.Drawing.Size(224, 26);
            this.menuSettingUsers.Text = "USERS";
            this.menuSettingUsers.Click += new System.EventHandler(this.menuSettingUsers_Click);
            // 
            // pROFILEToolStripMenuItem
            // 
            this.pROFILEToolStripMenuItem.Name = "pROFILEToolStripMenuItem";
            this.pROFILEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pROFILEToolStripMenuItem.Text = "PROFILE";
            this.pROFILEToolStripMenuItem.Click += new System.EventHandler(this.pROFILEToolStripMenuItem_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmUtama";
            this.Text = "SIMRS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUtama_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSetting;
        private System.Windows.Forms.ToolStripMenuItem menuSettingUsers;
        private System.Windows.Forms.ToolStripMenuItem pROFILEToolStripMenuItem;
    }
}