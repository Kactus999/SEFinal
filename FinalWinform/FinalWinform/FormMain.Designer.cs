
namespace FinalWinform
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_childFormTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lb_sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            this.lb_Hour = new System.Windows.Forms.Label();
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Summary = new FontAwesome.Sharp.IconButton();
            this.btn_Export = new FontAwesome.Sharp.IconButton();
            this.btn_Import = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btn_Summary);
            this.panelMenu.Controls.Add(this.btn_Export);
            this.panelMenu.Controls.Add(this.btn_Import);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 853);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_minimized);
            this.panel1.Controls.Add(this.btn_maximize);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.lb_childFormTitle);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 80);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_minimized
            // 
            this.btn_minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimized.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_minimized.Location = new System.Drawing.Point(986, 3);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(33, 32);
            this.btn_minimized.TabIndex = 4;
            this.btn_minimized.Text = "_";
            this.btn_minimized.UseVisualStyleBackColor = true;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_maximize.Location = new System.Drawing.Point(1016, 3);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(33, 32);
            this.btn_maximize.TabIndex = 3;
            this.btn_maximize.Text = "O";
            this.btn_maximize.UseVisualStyleBackColor = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_close.Location = new System.Drawing.Point(1046, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 32);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_childFormTitle
            // 
            this.lb_childFormTitle.AutoSize = true;
            this.lb_childFormTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_childFormTitle.Location = new System.Drawing.Point(69, 40);
            this.lb_childFormTitle.Name = "lb_childFormTitle";
            this.lb_childFormTitle.Size = new System.Drawing.Size(45, 17);
            this.lb_childFormTitle.TabIndex = 1;
            this.lb_childFormTitle.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.lb_sec);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.lb_Min);
            this.panelDesktop.Controls.Add(this.lb_Hour);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1082, 773);
            this.panelDesktop.TabIndex = 2;
            // 
            // lb_sec
            // 
            this.lb_sec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_sec.AutoSize = true;
            this.lb_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sec.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_sec.Location = new System.Drawing.Point(659, 380);
            this.lb_sec.Name = "lb_sec";
            this.lb_sec.Size = new System.Drawing.Size(47, 32);
            this.lb_sec.TabIndex = 3;
            this.lb_sec.Text = "10";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(507, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // lb_Min
            // 
            this.lb_Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Min.AutoSize = true;
            this.lb_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Min.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Min.Location = new System.Drawing.Point(538, 332);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(127, 91);
            this.lb_Min.TabIndex = 1;
            this.lb_Min.Text = "10";
            // 
            // lb_Hour
            // 
            this.lb_Hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Hour.AutoSize = true;
            this.lb_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hour.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Hour.Location = new System.Drawing.Point(386, 332);
            this.lb_Hour.Name = "lb_Hour";
            this.lb_Hour.Size = new System.Drawing.Size(127, 91);
            this.lb_Hour.TabIndex = 0;
            this.lb_Hour.Text = "10";
            // 
            // timerSecond
            // 
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(31, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btn_Summary
            // 
            this.btn_Summary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Summary.FlatAppearance.BorderSize = 0;
            this.btn_Summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Summary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Summary.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btn_Summary.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Summary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Summary.IconSize = 32;
            this.btn_Summary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Summary.Location = new System.Drawing.Point(0, 260);
            this.btn_Summary.Name = "btn_Summary";
            this.btn_Summary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Summary.Size = new System.Drawing.Size(220, 60);
            this.btn_Summary.TabIndex = 3;
            this.btn_Summary.Text = "Summary";
            this.btn_Summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Summary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Summary.UseVisualStyleBackColor = true;
            this.btn_Summary.Click += new System.EventHandler(this.btn_Summary_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Export.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btn_Export.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Export.IconSize = 32;
            this.btn_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Export.Location = new System.Drawing.Point(0, 200);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Export.Size = new System.Drawing.Size(220, 60);
            this.btn_Export.TabIndex = 2;
            this.btn_Export.Text = "Export";
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Import.FlatAppearance.BorderSize = 0;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Import.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btn_Import.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Import.IconSize = 32;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Location = new System.Drawing.Point(0, 140);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Import.Size = new System.Drawing.Size(220, 60);
            this.btn_Import.TabIndex = 1;
            this.btn_Import.Text = "Import";
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.White;
            this.btn_Home.Image = global::FinalWinform.Properties.Resources.KienAnCorp;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(217, 140);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 853);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Summary;
        private FontAwesome.Sharp.IconButton btn_Export;
        private FontAwesome.Sharp.IconButton btn_Import;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lb_childFormTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lb_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Min;
        private System.Windows.Forms.Label lb_Hour;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_maximize;
    }
}

