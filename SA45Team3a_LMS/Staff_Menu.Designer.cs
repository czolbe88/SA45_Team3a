namespace SA45Team3a_LMS
{
    partial class Staff_Menu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 17);
            this.button1.Size = new System.Drawing.Size(226, 30);
            this.button1.Text = "Maintain Book Catalog";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(438, 119);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 67);
            this.button2.Size = new System.Drawing.Size(226, 30);
            this.button2.Text = "Maintain Member Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(319, 142);
            this.panel1.Size = new System.Drawing.Size(285, 262);
            this.panel1.Controls.SetChildIndex(this.button2, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.button3, 0);
            this.panel1.Controls.SetChildIndex(this.button4, 0);
            // 
            // splitContainer1
            // 
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Check-out Titles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Check-in Titles";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Staff_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(957, 613);
            this.Name = "Staff_Menu";
            this.Text = "Staff Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
