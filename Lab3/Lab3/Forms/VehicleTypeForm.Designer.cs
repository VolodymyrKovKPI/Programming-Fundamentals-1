namespace Lab3
{
    partial class VehicleTypeForm
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
            this.BackToMain = new System.Windows.Forms.Button();
            this.CreateForm = new System.Windows.Forms.Button();
            this.EditForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Види транспорту";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BackToMain
            // 
            this.BackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMain.Location = new System.Drawing.Point(156, 323);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(125, 35);
            this.BackToMain.TabIndex = 2;
            this.BackToMain.Text = "Повернутись";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // CreateForm
            // 
            this.CreateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateForm.Location = new System.Drawing.Point(52, 255);
            this.CreateForm.Name = "CreateForm";
            this.CreateForm.Size = new System.Drawing.Size(99, 35);
            this.CreateForm.TabIndex = 3;
            this.CreateForm.Text = "Створити";
            this.CreateForm.UseVisualStyleBackColor = true;
            this.CreateForm.Click += new System.EventHandler(this.CreateForm_Click);
            // 
            // EditForm
            // 
            this.EditForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditForm.Location = new System.Drawing.Point(292, 255);
            this.EditForm.Name = "EditForm";
            this.EditForm.Size = new System.Drawing.Size(99, 35);
            this.EditForm.TabIndex = 4;
            this.EditForm.Text = "Змінити";
            this.EditForm.UseVisualStyleBackColor = true;
            this.EditForm.Click += new System.EventHandler(this.EditForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // VehicleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditForm);
            this.Controls.Add(this.CreateForm);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.label1);
            this.Name = "VehicleTypeForm";
            this.Text = "VehicleTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Button CreateForm;
        private System.Windows.Forms.Button EditForm;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}