
namespace FinalWinform
{
    partial class FormSummary
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
            this.datagrid_summary = new System.Windows.Forms.DataGridView();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_viewImport = new System.Windows.Forms.Button();
            this.btn_viewExport = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_viewing = new System.Windows.Forms.Label();
            this.btn_BestSelling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_summary)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_summary
            // 
            this.datagrid_summary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagrid_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_summary.Location = new System.Drawing.Point(322, 50);
            this.datagrid_summary.Name = "datagrid_summary";
            this.datagrid_summary.RowHeadersWidth = 51;
            this.datagrid_summary.RowTemplate.Height = 24;
            this.datagrid_summary.Size = new System.Drawing.Size(644, 469);
            this.datagrid_summary.TabIndex = 0;
            // 
            // combo_month
            // 
            this.combo_month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_month.FormattingEnabled = true;
            this.combo_month.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_month.Location = new System.Drawing.Point(119, 125);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(121, 24);
            this.combo_month.TabIndex = 1;
            // 
            // combo_year
            // 
            this.combo_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_year.FormattingEnabled = true;
            this.combo_year.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2039"});
            this.combo_year.Location = new System.Drawing.Point(119, 197);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(121, 24);
            this.combo_year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(25, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // btn_viewImport
            // 
            this.btn_viewImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_viewImport.Location = new System.Drawing.Point(30, 343);
            this.btn_viewImport.Name = "btn_viewImport";
            this.btn_viewImport.Size = new System.Drawing.Size(107, 32);
            this.btn_viewImport.TabIndex = 5;
            this.btn_viewImport.Text = "View Import";
            this.btn_viewImport.UseVisualStyleBackColor = true;
            this.btn_viewImport.Click += new System.EventHandler(this.btn_viewImport_Click);
            // 
            // btn_viewExport
            // 
            this.btn_viewExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_viewExport.Location = new System.Drawing.Point(170, 343);
            this.btn_viewExport.Name = "btn_viewExport";
            this.btn_viewExport.Size = new System.Drawing.Size(116, 32);
            this.btn_viewExport.TabIndex = 6;
            this.btn_viewExport.Text = "View Export";
            this.btn_viewExport.UseVisualStyleBackColor = true;
            this.btn_viewExport.Click += new System.EventHandler(this.btn_viewExport_Click);
            // 
            // lb_total
            // 
            this.lb_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_total.Location = new System.Drawing.Point(25, 254);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(64, 25);
            this.lb_total.TabIndex = 7;
            this.lb_total.Text = "label3";
            // 
            // lb_viewing
            // 
            this.lb_viewing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_viewing.AutoSize = true;
            this.lb_viewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viewing.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_viewing.Location = new System.Drawing.Point(512, 9);
            this.lb_viewing.Name = "lb_viewing";
            this.lb_viewing.Size = new System.Drawing.Size(64, 25);
            this.lb_viewing.TabIndex = 8;
            this.lb_viewing.Text = "label3";
            // 
            // btn_BestSelling
            // 
            this.btn_BestSelling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_BestSelling.Location = new System.Drawing.Point(30, 398);
            this.btn_BestSelling.Name = "btn_BestSelling";
            this.btn_BestSelling.Size = new System.Drawing.Size(107, 30);
            this.btn_BestSelling.TabIndex = 9;
            this.btn_BestSelling.Text = "Best-selling";
            this.btn_BestSelling.UseVisualStyleBackColor = true;
            this.btn_BestSelling.Click += new System.EventHandler(this.btn_BestSelling_Click);
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(890, 536);
            this.Controls.Add(this.btn_BestSelling);
            this.Controls.Add(this.lb_viewing);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.btn_viewExport);
            this.Controls.Add(this.btn_viewImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.combo_month);
            this.Controls.Add(this.datagrid_summary);
            this.Name = "FormSummary";
            this.Text = "FormSummary";
            this.Load += new System.EventHandler(this.FormSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_summary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_summary;
        private System.Windows.Forms.ComboBox combo_month;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_viewImport;
        private System.Windows.Forms.Button btn_viewExport;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_viewing;
        private System.Windows.Forms.Button btn_BestSelling;
    }
}