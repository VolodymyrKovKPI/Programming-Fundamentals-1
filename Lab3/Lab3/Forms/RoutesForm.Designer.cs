namespace Lab3
{
    partial class RoutesForm
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
            this.BackToMainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMainButton.Location = new System.Drawing.Point(116, 332);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(122, 37);
            this.BackToMainButton.TabIndex = 1;
            this.BackToMainButton.Text = "Повернутись";
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Маршрути";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMainButton);
            this.Name = "RoutesForm";
            this.Text = "RoutesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMainButton;
        private System.Windows.Forms.Label label1;
    }
}