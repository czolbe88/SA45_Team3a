namespace WindowsFormsApp1
{
    partial class MemberMenu
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
            this.searchCatalog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 119);
            this.button1.Size = new System.Drawing.Size(225, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(452, 147);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 71);
            this.button2.Size = new System.Drawing.Size(225, 30);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchCatalog);
            this.panel1.Location = new System.Drawing.Point(333, 170);
            this.panel1.Size = new System.Drawing.Size(285, 178);
            this.panel1.Controls.SetChildIndex(this.button2, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.searchCatalog, 0);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Location = new System.Drawing.Point(415, 21);
            // 
            // splitContainer1
            // 
            // 
            // searchCatalog
            // 
            this.searchCatalog.AutoSize = true;
            this.searchCatalog.Location = new System.Drawing.Point(36, 23);
            this.searchCatalog.Name = "searchCatalog";
            this.searchCatalog.Size = new System.Drawing.Size(225, 30);
            this.searchCatalog.TabIndex = 4;
            this.searchCatalog.Text = "Search Library Catalog";
            this.searchCatalog.UseVisualStyleBackColor = true;
            // 
            // MemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(957, 613);
            this.Name = "MemberMenu";
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

        private System.Windows.Forms.Button searchCatalog;
    }
}
