namespace MD
{
    partial class Accesslevels
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
            this.lbAccessLevels = new System.Windows.Forms.ListBox();
            this.lbApplications = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAccessLevel = new System.Windows.Forms.Button();
            this.txtAccessLevel = new System.Windows.Forms.TextBox();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.btnRemoveAccessLevel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccessLevels
            // 
            this.lbAccessLevels.FormattingEnabled = true;
            this.lbAccessLevels.ItemHeight = 19;
            this.lbAccessLevels.Location = new System.Drawing.Point(12, 113);
            this.lbAccessLevels.Name = "lbAccessLevels";
            this.lbAccessLevels.Size = new System.Drawing.Size(395, 118);
            this.lbAccessLevels.TabIndex = 0;
            // 
            // lbApplications
            // 
            this.lbApplications.FormattingEnabled = true;
            this.lbApplications.ItemHeight = 19;
            this.lbApplications.Location = new System.Drawing.Point(413, 113);
            this.lbApplications.Name = "lbApplications";
            this.lbApplications.Size = new System.Drawing.Size(376, 118);
            this.lbApplications.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.видToolStripMenuItem,
            this.toolStripMenuItem3,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 23);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 24);
            this.toolStripMenuItem2.Text = "Выход";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 23);
            this.toolStripMenuItem3.Text = "Настройки";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Уровни доступа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Доступное ПО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 5;
            // 
            // btnAddAccessLevel
            // 
            this.btnAddAccessLevel.Location = new System.Drawing.Point(12, 33);
            this.btnAddAccessLevel.Name = "btnAddAccessLevel";
            this.btnAddAccessLevel.Size = new System.Drawing.Size(228, 29);
            this.btnAddAccessLevel.TabIndex = 6;
            this.btnAddAccessLevel.Text = "Добавление уровня доступа:";
            this.btnAddAccessLevel.UseVisualStyleBackColor = true;
            this.btnAddAccessLevel.Click += new System.EventHandler(this.btnAddAccessLevel_Click_1);
            // 
            // txtAccessLevel
            // 
            this.txtAccessLevel.Location = new System.Drawing.Point(246, 35);
            this.txtAccessLevel.Name = "txtAccessLevel";
            this.txtAccessLevel.Size = new System.Drawing.Size(161, 26);
            this.txtAccessLevel.TabIndex = 7;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(413, 33);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(209, 29);
            this.btnAddApplication.TabIndex = 8;
            this.btnAddApplication.Text = "Добавление приложения:";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click_1);
            // 
            // txtApplication
            // 
            this.txtApplication.Location = new System.Drawing.Point(628, 35);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(161, 26);
            this.txtApplication.TabIndex = 9;
            // 
            // btnRemoveAccessLevel
            // 
            this.btnRemoveAccessLevel.Location = new System.Drawing.Point(12, 244);
            this.btnRemoveAccessLevel.Name = "btnRemoveAccessLevel";
            this.btnRemoveAccessLevel.Size = new System.Drawing.Size(204, 29);
            this.btnRemoveAccessLevel.TabIndex = 10;
            this.btnRemoveAccessLevel.Text = "Удаление уровня доступа";
            this.btnRemoveAccessLevel.UseVisualStyleBackColor = true;
            this.btnRemoveAccessLevel.Click += new System.EventHandler(this.btnRemoveAccessLevel_Click_1);
            // 
            // Accesslevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 285);
            this.Controls.Add(this.btnRemoveAccessLevel);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.txtAccessLevel);
            this.Controls.Add(this.btnAddAccessLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbApplications);
            this.Controls.Add(this.lbAccessLevels);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accesslevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectMD";
            this.Load += new System.EventHandler(this.Accesslevels_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAccessLevels;
        private System.Windows.Forms.ListBox lbApplications;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAccessLevel;
        private System.Windows.Forms.TextBox txtAccessLevel;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.Button btnRemoveAccessLevel;
    }
}