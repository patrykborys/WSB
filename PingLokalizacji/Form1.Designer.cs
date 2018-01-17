namespace PingLokalizacji
{
    partial class Form1
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
            this.wynik = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ipText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Połącz = new System.Windows.Forms.Button();
            this.Zeruj = new System.Windows.Forms.Button();
            this.ZerujIP = new System.Windows.Forms.Button();
            this.wyślij = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(12, 77);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(383, 126);
            this.wynik.TabIndex = 0;
            this.wynik.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikMenu,
            this.sQLToolStripMenuItem,
            this.autorMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikMenu
            // 
            this.plikMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.plikMenu.Name = "plikMenu";
            this.plikMenu.Size = new System.Drawing.Size(38, 20);
            this.plikMenu.Text = "Plik";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // autorMenu
            // 
            this.autorMenu.Name = "autorMenu";
            this.autorMenu.Size = new System.Drawing.Size(49, 20);
            this.autorMenu.Text = "Autor";
            this.autorMenu.Click += new System.EventHandler(this.autorMenu_Click);
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(65, 54);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(148, 20);
            this.ipText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adres IP";
            // 
            // Połącz
            // 
            this.Połącz.Location = new System.Drawing.Point(320, 51);
            this.Połącz.Name = "Połącz";
            this.Połącz.Size = new System.Drawing.Size(75, 23);
            this.Połącz.TabIndex = 4;
            this.Połącz.Text = "Połącz";
            this.Połącz.UseVisualStyleBackColor = true;
            this.Połącz.Click += new System.EventHandler(this.Połącz_Click);
            // 
            // Zeruj
            // 
            this.Zeruj.Location = new System.Drawing.Point(12, 209);
            this.Zeruj.Name = "Zeruj";
            this.Zeruj.Size = new System.Drawing.Size(112, 23);
            this.Zeruj.TabIndex = 5;
            this.Zeruj.Text = "Wyczyść wynik";
            this.Zeruj.UseVisualStyleBackColor = true;
            this.Zeruj.Click += new System.EventHandler(this.Zeruj_Click);
            // 
            // ZerujIP
            // 
            this.ZerujIP.Location = new System.Drawing.Point(239, 51);
            this.ZerujIP.Name = "ZerujIP";
            this.ZerujIP.Size = new System.Drawing.Size(75, 23);
            this.ZerujIP.TabIndex = 6;
            this.ZerujIP.Text = "Wyczyść IP";
            this.ZerujIP.UseVisualStyleBackColor = true;
            this.ZerujIP.Click += new System.EventHandler(this.ZerujIP_Click);
            // 
            // wyślij
            // 
            this.wyślij.Location = new System.Drawing.Point(278, 238);
            this.wyślij.Name = "wyślij";
            this.wyślij.Size = new System.Drawing.Size(116, 23);
            this.wyślij.TabIndex = 7;
            this.wyślij.Text = "Wyślij powiadomienie";
            this.wyślij.UseVisualStyleBackColor = true;
            this.wyślij.Click += new System.EventHandler(this.wyślij_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(12, 241);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(260, 20);
            this.mail.TabIndex = 8;
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 328);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.wyślij);
            this.Controls.Add(this.ZerujIP);
            this.Controls.Add(this.Zeruj);
            this.Controls.Add(this.Połącz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ping";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox wynik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorMenu;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Połącz;
        private System.Windows.Forms.Button Zeruj;
        private System.Windows.Forms.Button ZerujIP;
        private System.Windows.Forms.Button wyślij;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
    }
}

