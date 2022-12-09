
namespace FinalWinform
{
    partial class FormImport
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
            this.dataGridImportDetails = new System.Windows.Forms.DataGridView();
            this.btn_newImport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_finishImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridImportDetails
            // 
            this.dataGridImportDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridImportDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImportDetails.Location = new System.Drawing.Point(470, 178);
            this.dataGridImportDetails.Name = "dataGridImportDetails";
            this.dataGridImportDetails.RowHeadersWidth = 51;
            this.dataGridImportDetails.RowTemplate.Height = 24;
            this.dataGridImportDetails.Size = new System.Drawing.Size(503, 329);
            this.dataGridImportDetails.TabIndex = 1;
            // 
            // btn_newImport
            // 
            this.btn_newImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_newImport.Location = new System.Drawing.Point(855, 552);
            this.btn_newImport.Name = "btn_newImport";
            this.btn_newImport.Size = new System.Drawing.Size(118, 26);
            this.btn_newImport.TabIndex = 2;
            this.btn_newImport.Text = "New item";
            this.btn_newImport.UseVisualStyleBackColor = true;
            this.btn_newImport.Click += new System.EventHandler(this.btn_newImport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Probiotic 10",
            "Co Q-10 for Heart Health",
            "Triple Strength Omega-3 Fish Oil",
            "Lutein Antioxidant for Eye Health",
            "Alpha Lipoic Acid 300 mg.",
            "Triple Omega 3 6 9",
            "Quercetin 600mg",
            "Codeage Liposomal Glutathione",
            "L-Arginine 1000 mg"});
            this.comboBox1.Location = new System.Drawing.Point(243, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(243, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btn_finishImport
            // 
            this.btn_finishImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_finishImport.Location = new System.Drawing.Point(708, 552);
            this.btn_finishImport.Name = "btn_finishImport";
            this.btn_finishImport.Size = new System.Drawing.Size(118, 26);
            this.btn_finishImport.TabIndex = 5;
            this.btn_finishImport.Text = "Import";
            this.btn_finishImport.UseVisualStyleBackColor = true;
            this.btn_finishImport.Click += new System.EventHandler(this.btn_finishImport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(120, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(120, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(120, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Price:";
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1099, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finishImport);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_newImport);
            this.Controls.Add(this.dataGridImportDetails);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.Load += new System.EventHandler(this.FormImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridImportDetails;
        private System.Windows.Forms.Button btn_newImport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_finishImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}