namespace Lab3.Forms
{
    partial class CastsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputBoxUlong = new System.Windows.Forms.TextBox();
            this.DoItButton = new System.Windows.Forms.Button();
            this.InputBoxFloat = new System.Windows.Forms.TextBox();
            this.OutputFloatBox = new System.Windows.Forms.TextBox();
            this.OutputSbyteBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ulong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(256, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "float";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "float";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "sbyte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(145, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Convert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(145, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parse";
            // 
            // InputBoxUlong
            // 
            this.InputBoxUlong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBoxUlong.Location = new System.Drawing.Point(33, 71);
            this.InputBoxUlong.Multiline = true;
            this.InputBoxUlong.Name = "InputBoxUlong";
            this.InputBoxUlong.Size = new System.Drawing.Size(83, 38);
            this.InputBoxUlong.TabIndex = 6;
            // 
            // DoItButton
            // 
            this.DoItButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoItButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoItButton.Location = new System.Drawing.Point(0, 705);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(363, 46);
            this.DoItButton.TabIndex = 8;
            this.DoItButton.Text = "НАТИСНИ МЕНЕ!";
            this.DoItButton.UseVisualStyleBackColor = true;
            this.DoItButton.Click += new System.EventHandler(this.DoItButton_Click);
            // 
            // InputBoxFloat
            // 
            this.InputBoxFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBoxFloat.Location = new System.Drawing.Point(33, 149);
            this.InputBoxFloat.Multiline = true;
            this.InputBoxFloat.Name = "InputBoxFloat";
            this.InputBoxFloat.Size = new System.Drawing.Size(83, 38);
            this.InputBoxFloat.TabIndex = 9;
            // 
            // OutputFloatBox
            // 
            this.OutputFloatBox.Enabled = false;
            this.OutputFloatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputFloatBox.Location = new System.Drawing.Point(227, 71);
            this.OutputFloatBox.Multiline = true;
            this.OutputFloatBox.Name = "OutputFloatBox";
            this.OutputFloatBox.ReadOnly = true;
            this.OutputFloatBox.Size = new System.Drawing.Size(83, 38);
            this.OutputFloatBox.TabIndex = 7;
            // 
            // OutputSbyteBox
            // 
            this.OutputSbyteBox.Enabled = false;
            this.OutputSbyteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputSbyteBox.Location = new System.Drawing.Point(227, 149);
            this.OutputSbyteBox.Multiline = true;
            this.OutputSbyteBox.Name = "OutputSbyteBox";
            this.OutputSbyteBox.ReadOnly = true;
            this.OutputSbyteBox.Size = new System.Drawing.Size(83, 38);
            this.OutputSbyteBox.TabIndex = 10;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.Location = new System.Drawing.Point(108, 271);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(150, 58);
            this.ConvertButton.TabIndex = 12;
            this.ConvertButton.Text = "Конвертуй!";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CastsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 751);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputSbyteBox);
            this.Controls.Add(this.InputBoxFloat);
            this.Controls.Add(this.DoItButton);
            this.Controls.Add(this.OutputFloatBox);
            this.Controls.Add(this.InputBoxUlong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CastsForm";
            this.Text = "CastsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputBoxUlong;
        private System.Windows.Forms.Button DoItButton;
        private System.Windows.Forms.TextBox InputBoxFloat;
        private System.Windows.Forms.TextBox OutputFloatBox;
        private System.Windows.Forms.TextBox OutputSbyteBox;
        private System.Windows.Forms.Button ConvertButton;
    }
}