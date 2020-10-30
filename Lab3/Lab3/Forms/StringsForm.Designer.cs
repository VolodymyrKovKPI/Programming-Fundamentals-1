namespace Lab3.Forms
{
    partial class StringsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputString = new System.Windows.Forms.TextBox();
            this.OutputString = new System.Windows.Forms.TextBox();
            this.DoWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Робота зі строками!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputString
            // 
            this.InputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputString.Location = new System.Drawing.Point(12, 79);
            this.InputString.Multiline = true;
            this.InputString.Name = "InputString";
            this.InputString.Size = new System.Drawing.Size(459, 44);
            this.InputString.TabIndex = 1;
            // 
            // OutputString
            // 
            this.OutputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputString.Location = new System.Drawing.Point(12, 203);
            this.OutputString.Multiline = true;
            this.OutputString.Name = "OutputString";
            this.OutputString.ReadOnly = true;
            this.OutputString.Size = new System.Drawing.Size(459, 44);
            this.OutputString.TabIndex = 2;
            // 
            // DoWork
            // 
            this.DoWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoWork.Location = new System.Drawing.Point(162, 352);
            this.DoWork.Name = "DoWork";
            this.DoWork.Size = new System.Drawing.Size(140, 51);
            this.DoWork.TabIndex = 3;
            this.DoWork.Text = "Робота!";
            this.DoWork.UseVisualStyleBackColor = true;
            this.DoWork.Click += new System.EventHandler(this.DoWork_Click);
            // 
            // StringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.DoWork);
            this.Controls.Add(this.OutputString);
            this.Controls.Add(this.InputString);
            this.Controls.Add(this.label1);
            this.Name = "StringsForm";
            this.Text = "StringsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputString;
        private System.Windows.Forms.TextBox OutputString;
        private System.Windows.Forms.Button DoWork;
    }
}