namespace Lab3
{
    partial class MainWindow
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GarageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CastsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.StringsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.CastsMenuItem,
            this.StringsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AboutMenuItem.Text = "Про програму";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitToolStripMenuItem.Text = "Вихід";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclesToolStripMenuItem,
            this.RoutesMenuItem,
            this.StopsMenuItem,
            this.GarageMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.navigateToolStripMenuItem.Text = "Навігація";
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vehiclesToolStripMenuItem.Text = "Види транспорту";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // RoutesMenuItem
            // 
            this.RoutesMenuItem.Name = "RoutesMenuItem";
            this.RoutesMenuItem.Size = new System.Drawing.Size(167, 22);
            this.RoutesMenuItem.Text = "Маршрути";
            this.RoutesMenuItem.Click += new System.EventHandler(this.RoutesMenuItem_Click);
            // 
            // StopsMenuItem
            // 
            this.StopsMenuItem.Name = "StopsMenuItem";
            this.StopsMenuItem.Size = new System.Drawing.Size(167, 22);
            this.StopsMenuItem.Text = "Зупинки";
            this.StopsMenuItem.Click += new System.EventHandler(this.StopsMenuItem_Click);
            // 
            // GarageMenuItem
            // 
            this.GarageMenuItem.Name = "GarageMenuItem";
            this.GarageMenuItem.Size = new System.Drawing.Size(167, 22);
            this.GarageMenuItem.Text = "Автопарк";
            this.GarageMenuItem.Click += new System.EventHandler(this.GarageMenuItem_Click);
            // 
            // CastsMenuItem
            // 
            this.CastsMenuItem.Name = "CastsMenuItem";
            this.CastsMenuItem.Size = new System.Drawing.Size(86, 20);
            this.CastsMenuItem.Text = "Приведення";
            this.CastsMenuItem.Click += new System.EventHandler(this.CastsMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабороторна робота №3 \"Транспорт\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StringsMenuItem
            // 
            this.StringsMenuItem.Name = "StringsMenuItem";
            this.StringsMenuItem.Size = new System.Drawing.Size(51, 20);
            this.StringsMenuItem.Text = "Рядки";
            this.StringsMenuItem.Click += new System.EventHandler(this.StringsMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Lab3.Properties.Resources.public_transport_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoutesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GarageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CastsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StringsMenuItem;
    }
}