namespace bd_CourseProject.src.view
{
    partial class ConnectionDBWindow
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
            this.cbAuthentication = new System.Windows.Forms.ComboBox();
            this.tbNameSQLServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Aunthentication",
            "SQL Server Aunthentication"});
            this.cbAuthentication.Location = new System.Drawing.Point(152, 105);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(181, 21);
            this.cbAuthentication.TabIndex = 2;
            this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.CbAuthentication_SelectedIndexChanged);
            // 
            // tbNameSQLServer
            // 
            this.tbNameSQLServer.Location = new System.Drawing.Point(152, 76);
            this.tbNameSQLServer.Name = "tbNameSQLServer";
            this.tbNameSQLServer.Size = new System.Drawing.Size(181, 20);
            this.tbNameSQLServer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SQL сервер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Проверка подлинности";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(3, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 115);
            this.panel1.TabIndex = 8;
            // 
            // ConnectionDBWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameSQLServer);
            this.Controls.Add(this.cbAuthentication);
            this.Name = "ConnectionDBWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database connection";
            this.Load += new System.EventHandler(this.ConnectionDBWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAuthentication;
        private System.Windows.Forms.TextBox tbNameSQLServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNameBD;
        private System.Windows.Forms.Panel panel1;
    }
}