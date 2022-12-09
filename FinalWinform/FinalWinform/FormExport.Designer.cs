
namespace FinalWinform
{
    partial class FormExport
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
            this.dataGridExport = new System.Windows.Forms.DataGridView();
            this.btn_arrived = new System.Windows.Forms.Button();
            this.btn_paid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridExport
            // 
            this.dataGridExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExport.Location = new System.Drawing.Point(106, 96);
            this.dataGridExport.Name = "dataGridExport";
            this.dataGridExport.RowHeadersWidth = 51;
            this.dataGridExport.RowTemplate.Height = 24;
            this.dataGridExport.Size = new System.Drawing.Size(662, 345);
            this.dataGridExport.TabIndex = 0;
            this.dataGridExport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridExport_CellContentClick);
            // 
            // btn_arrived
            // 
            this.btn_arrived.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_arrived.Location = new System.Drawing.Point(688, 487);
            this.btn_arrived.Name = "btn_arrived";
            this.btn_arrived.Size = new System.Drawing.Size(80, 37);
            this.btn_arrived.TabIndex = 1;
            this.btn_arrived.Text = "Arrived";
            this.btn_arrived.UseVisualStyleBackColor = true;
            this.btn_arrived.Click += new System.EventHandler(this.btn_arrived_Click);
            // 
            // btn_paid
            // 
            this.btn_paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paid.Location = new System.Drawing.Point(568, 484);
            this.btn_paid.Name = "btn_paid";
            this.btn_paid.Size = new System.Drawing.Size(86, 37);
            this.btn_paid.TabIndex = 2;
            this.btn_paid.Text = "Paid";
            this.btn_paid.UseVisualStyleBackColor = true;
            this.btn_paid.Click += new System.EventHandler(this.btn_paid_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(313, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(890, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_paid);
            this.Controls.Add(this.btn_arrived);
            this.Controls.Add(this.dataGridExport);
            this.Name = "FormExport";
            this.Text = "FormExport";
            this.Load += new System.EventHandler(this.FormExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridExport;
        private System.Windows.Forms.Button btn_arrived;
        private System.Windows.Forms.Button btn_paid;
        private System.Windows.Forms.Label label1;
    }
}