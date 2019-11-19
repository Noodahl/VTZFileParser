namespace InterfaceBuilder
{
    partial class InterfaceBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceBuilder));
            this.Browse_Btn = new System.Windows.Forms.Button();
            this.Convert_Btn = new System.Windows.Forms.Button();
            this.Directory_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDirectory_Btn = new System.Windows.Forms.Button();
            this.saveLocation_TxtBox = new System.Windows.Forms.TextBox();
            this.saveLocation_btn = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editJoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_Btn.Location = new System.Drawing.Point(528, 95);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(273, 64);
            this.Browse_Btn.TabIndex = 0;
            this.Browse_Btn.Text = "Browse";
            this.Browse_Btn.UseVisualStyleBackColor = true;
            this.Browse_Btn.UseWaitCursor = true;
            this.Browse_Btn.Click += new System.EventHandler(this.Browse_Btn_Click);
            // 
            // Convert_Btn
            // 
            this.Convert_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Convert_Btn.Enabled = false;
            this.Convert_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Convert_Btn.FlatAppearance.BorderSize = 10;
            this.Convert_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_Btn.Location = new System.Drawing.Point(30, 303);
            this.Convert_Btn.Name = "Convert_Btn";
            this.Convert_Btn.Size = new System.Drawing.Size(273, 102);
            this.Convert_Btn.TabIndex = 1;
            this.Convert_Btn.Text = "Convert";
            this.Convert_Btn.UseVisualStyleBackColor = false;
            this.Convert_Btn.UseWaitCursor = true;
            this.Convert_Btn.Click += new System.EventHandler(this.Convert_Btn_Click);
            // 
            // Directory_TextBox
            // 
            this.Directory_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directory_TextBox.Location = new System.Drawing.Point(85, 108);
            this.Directory_TextBox.Name = "Directory_TextBox";
            this.Directory_TextBox.Size = new System.Drawing.Size(435, 39);
            this.Directory_TextBox.TabIndex = 4;
            this.Directory_TextBox.Text = ".VTZ file to Convert";
            this.Directory_TextBox.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Browse and Select the .vtz File";
            this.label1.UseWaitCursor = true;
            // 
            // OpenDirectory_Btn
            // 
            this.OpenDirectory_Btn.BackColor = System.Drawing.Color.DarkGray;
            this.OpenDirectory_Btn.Enabled = false;
            this.OpenDirectory_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDirectory_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDirectory_Btn.Location = new System.Drawing.Point(360, 303);
            this.OpenDirectory_Btn.Name = "OpenDirectory_Btn";
            this.OpenDirectory_Btn.Size = new System.Drawing.Size(273, 102);
            this.OpenDirectory_Btn.TabIndex = 6;
            this.OpenDirectory_Btn.Text = "Open Directory";
            this.OpenDirectory_Btn.UseVisualStyleBackColor = false;
            this.OpenDirectory_Btn.UseWaitCursor = true;
            this.OpenDirectory_Btn.Click += new System.EventHandler(this.OpenDirectory_Btn_Click);
            // 
            // saveLocation_TxtBox
            // 
            this.saveLocation_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocation_TxtBox.Location = new System.Drawing.Point(85, 209);
            this.saveLocation_TxtBox.Name = "saveLocation_TxtBox";
            this.saveLocation_TxtBox.Size = new System.Drawing.Size(435, 39);
            this.saveLocation_TxtBox.TabIndex = 7;
            this.saveLocation_TxtBox.Text = "Save Location";
            this.saveLocation_TxtBox.UseWaitCursor = true;
            // 
            // saveLocation_btn
            // 
            this.saveLocation_btn.Enabled = false;
            this.saveLocation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLocation_btn.Location = new System.Drawing.Point(528, 196);
            this.saveLocation_btn.Name = "saveLocation_btn";
            this.saveLocation_btn.Size = new System.Drawing.Size(273, 64);
            this.saveLocation_btn.TabIndex = 8;
            this.saveLocation_btn.Text = "Browse";
            this.saveLocation_btn.UseVisualStyleBackColor = true;
            this.saveLocation_btn.UseWaitCursor = true;
            this.saveLocation_btn.Click += new System.EventHandler(this.SaveLocation_btn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1034, 33);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editJoinsToolStripMenuItem});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.testingToolStripMenuItem.Text = "Testing";
            // 
            // editJoinsToolStripMenuItem
            // 
            this.editJoinsToolStripMenuItem.Name = "editJoinsToolStripMenuItem";
            this.editJoinsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editJoinsToolStripMenuItem.Text = "Edit Joins";
            this.editJoinsToolStripMenuItem.Click += new System.EventHandler(this.EditJoinsToolStripMenuItem_Click);
            // 
            // InterfaceBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1034, 636);
            this.Controls.Add(this.saveLocation_btn);
            this.Controls.Add(this.saveLocation_TxtBox);
            this.Controls.Add(this.OpenDirectory_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Directory_TextBox);
            this.Controls.Add(this.Convert_Btn);
            this.Controls.Add(this.Browse_Btn);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceBuilder";
            this.Text = "Interface Builder";
            this.UseWaitCursor = true;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse_Btn;
        private System.Windows.Forms.Button Convert_Btn;
        private System.Windows.Forms.TextBox Directory_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenDirectory_Btn;
        private System.Windows.Forms.TextBox saveLocation_TxtBox;
        private System.Windows.Forms.Button saveLocation_btn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editJoinsToolStripMenuItem;
    }
}

