namespace WindowsFormsApp1
{
    partial class main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBDriver13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBDriver143ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBMinimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFlashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.platformToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMsFastbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalarCustomRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bootloader";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bloquear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Desbloquear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(192, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slot";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 44);
            this.button7.TabIndex = 3;
            this.button7.Text = "Trocar para Slot B";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 44);
            this.button6.TabIndex = 2;
            this.button6.Text = "Trocar para Slot A";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "Status";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(44, 234);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 45);
            this.button8.TabIndex = 3;
            this.button8.Text = "CMD ADB";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(224, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 45);
            this.button9.TabIndex = 4;
            this.button9.Text = "Modo EDL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.rOMsFastbootToolStripMenuItem,
            this.instalarCustomRecoveryToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDBDriversToolStripMenuItem,
            this.miFlashToolStripMenuItem1,
            this.platformToolsToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // aDBDriversToolStripMenuItem
            // 
            this.aDBDriversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDBDriver13ToolStripMenuItem,
            this.aDBDriver143ToolStripMenuItem,
            this.aDBMinimalToolStripMenuItem});
            this.aDBDriversToolStripMenuItem.Name = "aDBDriversToolStripMenuItem";
            this.aDBDriversToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aDBDriversToolStripMenuItem.Text = "ADB Drivers";
            // 
            // aDBDriver13ToolStripMenuItem
            // 
            this.aDBDriver13ToolStripMenuItem.Name = "aDBDriver13ToolStripMenuItem";
            this.aDBDriver13ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aDBDriver13ToolStripMenuItem.Text = "ADB Driver 1.3";
            this.aDBDriver13ToolStripMenuItem.Click += new System.EventHandler(this.aDBDriver13ToolStripMenuItem_Click);
            // 
            // aDBDriver143ToolStripMenuItem
            // 
            this.aDBDriver143ToolStripMenuItem.Name = "aDBDriver143ToolStripMenuItem";
            this.aDBDriver143ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aDBDriver143ToolStripMenuItem.Text = "ADB Driver 1.4.3";
            this.aDBDriver143ToolStripMenuItem.Click += new System.EventHandler(this.aDBDriver143ToolStripMenuItem_Click);
            // 
            // aDBMinimalToolStripMenuItem
            // 
            this.aDBMinimalToolStripMenuItem.Name = "aDBMinimalToolStripMenuItem";
            this.aDBMinimalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aDBMinimalToolStripMenuItem.Text = "ADB Minimal";
            this.aDBMinimalToolStripMenuItem.Click += new System.EventHandler(this.aDBMinimalToolStripMenuItem_Click);
            // 
            // miFlashToolStripMenuItem1
            // 
            this.miFlashToolStripMenuItem1.Name = "miFlashToolStripMenuItem1";
            this.miFlashToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.miFlashToolStripMenuItem1.Text = "Mi Flash";
            this.miFlashToolStripMenuItem1.Click += new System.EventHandler(this.miFlashToolStripMenuItem1_Click);
            // 
            // platformToolsToolStripMenuItem
            // 
            this.platformToolsToolStripMenuItem.Name = "platformToolsToolStripMenuItem";
            this.platformToolsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.platformToolsToolStripMenuItem.Text = "Platform Tools";
            this.platformToolsToolStripMenuItem.Click += new System.EventHandler(this.platformToolsToolStripMenuItem_Click);
            // 
            // rOMsFastbootToolStripMenuItem
            // 
            this.rOMsFastbootToolStripMenuItem.Name = "rOMsFastbootToolStripMenuItem";
            this.rOMsFastbootToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.rOMsFastbootToolStripMenuItem.Text = "ROMs Fastboot";
            this.rOMsFastbootToolStripMenuItem.Click += new System.EventHandler(this.rOMsFastbootToolStripMenuItem_Click);
            // 
            // instalarCustomRecoveryToolStripMenuItem
            // 
            this.instalarCustomRecoveryToolStripMenuItem.Name = "instalarCustomRecoveryToolStripMenuItem";
            this.instalarCustomRecoveryToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.instalarCustomRecoveryToolStripMenuItem.Text = "Instalar Custom Recovery";
            this.instalarCustomRecoveryToolStripMenuItem.Click += new System.EventHandler(this.instalarCustomRecoveryToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(373, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gabriel Maier";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xiaomi Fastboot Tool v4 - Gabriel Maier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBDriver13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBDriver143ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDBMinimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFlashToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem platformToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOMsFastbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instalarCustomRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

