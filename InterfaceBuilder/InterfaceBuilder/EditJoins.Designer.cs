namespace InterfaceBuilder
{
    partial class EditJoins
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
            this.JoinLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // JoinLayout
            // 
            this.JoinLayout.AutoSize = true;
            this.JoinLayout.ColumnCount = 2;
            this.JoinLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25974F));
            this.JoinLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74026F));
            this.JoinLayout.Location = new System.Drawing.Point(36, 63);
            this.JoinLayout.Name = "JoinLayout";
            this.JoinLayout.RowCount = 2;
            this.JoinLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.JoinLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.JoinLayout.Size = new System.Drawing.Size(873, 483);
            this.JoinLayout.TabIndex = 0;
            // 
            // EditJoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JoinLayout);
            this.Name = "EditJoins";
            this.Size = new System.Drawing.Size(957, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel JoinLayout;
    }
}
