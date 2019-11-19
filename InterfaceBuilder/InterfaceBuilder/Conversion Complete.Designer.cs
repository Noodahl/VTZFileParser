namespace InterfaceBuilder
{
    partial class Conversion_Complete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conversion_Lbl = new System.Windows.Forms.Label();
            this.conversionReport_Lbl = new System.Windows.Forms.Label();
            this.modifyJoins_Btn = new System.Windows.Forms.Button();
            this.convertCmplt_Btn = new System.Windows.Forms.Button();
            this.convertCmplt2_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conversion_Lbl
            // 
            this.conversion_Lbl.AutoSize = true;
            this.conversion_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion_Lbl.Location = new System.Drawing.Point(197, 123);
            this.conversion_Lbl.Name = "conversion_Lbl";
            this.conversion_Lbl.Size = new System.Drawing.Size(641, 92);
            this.conversion_Lbl.TabIndex = 0;
            this.conversion_Lbl.Text = "Conversion Complete!\r\nPlease see additional details below";
            this.conversion_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.conversion_Lbl.Click += new System.EventHandler(this.Conversion_Lbl_Click);
            // 
            // conversionReport_Lbl
            // 
            this.conversionReport_Lbl.AutoSize = true;
            this.conversionReport_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionReport_Lbl.Location = new System.Drawing.Point(97, 287);
            this.conversionReport_Lbl.Name = "conversionReport_Lbl";
            this.conversionReport_Lbl.Size = new System.Drawing.Size(791, 46);
            this.conversionReport_Lbl.TabIndex = 1;
            this.conversionReport_Lbl.Text = "16000 /16000 joins are using default names";
            // 
            // modifyJoins_Btn
            // 
            this.modifyJoins_Btn.BackColor = System.Drawing.Color.DarkOrange;
            this.modifyJoins_Btn.Enabled = false;
            this.modifyJoins_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.modifyJoins_Btn.Location = new System.Drawing.Point(38, 472);
            this.modifyJoins_Btn.Name = "modifyJoins_Btn";
            this.modifyJoins_Btn.Size = new System.Drawing.Size(273, 102);
            this.modifyJoins_Btn.TabIndex = 2;
            this.modifyJoins_Btn.Text = "Modify";
            this.modifyJoins_Btn.UseVisualStyleBackColor = false;
            // 
            // convertCmplt_Btn
            // 
            this.convertCmplt_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.convertCmplt_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.convertCmplt_Btn.Location = new System.Drawing.Point(370, 472);
            this.convertCmplt_Btn.Name = "convertCmplt_Btn";
            this.convertCmplt_Btn.Size = new System.Drawing.Size(273, 102);
            this.convertCmplt_Btn.TabIndex = 3;
            this.convertCmplt_Btn.Text = "Complete";
            this.convertCmplt_Btn.UseVisualStyleBackColor = false;
            // 
            // convertCmplt2_Btn
            // 
            this.convertCmplt2_Btn.BackColor = System.Drawing.Color.LightGreen;
            this.convertCmplt2_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.convertCmplt2_Btn.Location = new System.Drawing.Point(700, 472);
            this.convertCmplt2_Btn.Name = "convertCmplt2_Btn";
            this.convertCmplt2_Btn.Size = new System.Drawing.Size(273, 102);
            this.convertCmplt2_Btn.TabIndex = 4;
            this.convertCmplt2_Btn.Text = "Complete and Open";
            this.convertCmplt2_Btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(337, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 193);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Conversion_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.convertCmplt2_Btn);
            this.Controls.Add(this.convertCmplt_Btn);
            this.Controls.Add(this.modifyJoins_Btn);
            this.Controls.Add(this.conversionReport_Lbl);
            this.Controls.Add(this.conversion_Lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Conversion_Complete";
            this.Size = new System.Drawing.Size(1056, 692);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conversion_Lbl;
        private System.Windows.Forms.Label conversionReport_Lbl;
        private System.Windows.Forms.Button modifyJoins_Btn;
        private System.Windows.Forms.Button convertCmplt_Btn;
        private System.Windows.Forms.Button convertCmplt2_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
