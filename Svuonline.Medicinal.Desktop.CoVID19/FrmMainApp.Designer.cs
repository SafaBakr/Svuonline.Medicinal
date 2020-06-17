namespace Svuonline.Medicinal.Desktop.CoVID19
{
    partial class FrmMainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainApp));
            this.SideMenuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnReports = new FontAwesome.Sharp.IconButton();
            this.BtnPatientData = new FontAwesome.Sharp.IconButton();
            this.LogoPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.TitleBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.FrmMainDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FrmMainShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.FrmMainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PanelDesktop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideMenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(188)))), ((int)(((byte)(178)))));
            this.SideMenuPanel.Controls.Add(this.iconButton1);
            this.SideMenuPanel.Controls.Add(this.BtnReports);
            this.SideMenuPanel.Controls.Add(this.BtnPatientData);
            this.SideMenuPanel.Controls.Add(this.LogoPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.ShadowDecoration.Parent = this.SideMenuPanel;
            this.SideMenuPanel.Size = new System.Drawing.Size(220, 491);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Almohanad long kaf", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iconButton1.ForeColor = System.Drawing.Color.Snow;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.iconButton1.IconSize = 36;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 260);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(220, 60);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "معلومات المستخدم";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.BtnUserInfo_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReports.Font = new System.Drawing.Font("Almohanad long kaf", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnReports.ForeColor = System.Drawing.Color.Snow;
            this.BtnReports.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.BtnReports.IconSize = 36;
            this.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.Location = new System.Drawing.Point(0, 200);
            this.BtnReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnReports.Rotation = 0D;
            this.BtnReports.Size = new System.Drawing.Size(220, 60);
            this.BtnReports.TabIndex = 2;
            this.BtnReports.Text = " التقــاريـر";
            this.BtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // BtnPatientData
            // 
            this.BtnPatientData.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPatientData.FlatAppearance.BorderSize = 0;
            this.BtnPatientData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPatientData.Font = new System.Drawing.Font("Almohanad long kaf", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnPatientData.ForeColor = System.Drawing.Color.Snow;
            this.BtnPatientData.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.BtnPatientData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.BtnPatientData.IconSize = 36;
            this.BtnPatientData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatientData.Location = new System.Drawing.Point(0, 140);
            this.BtnPatientData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPatientData.Name = "BtnPatientData";
            this.BtnPatientData.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.BtnPatientData.Rotation = 0D;
            this.BtnPatientData.Size = new System.Drawing.Size(220, 60);
            this.BtnPatientData.TabIndex = 1;
            this.BtnPatientData.Text = "بيـانات الحـالة";
            this.BtnPatientData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatientData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientData.UseVisualStyleBackColor = true;
            this.BtnPatientData.Click += new System.EventHandler(this.BtnPatientData_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.BtnHome);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.ShadowDecoration.Parent = this.LogoPanel;
            this.LogoPanel.Size = new System.Drawing.Size(220, 140);
            this.LogoPanel.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(0, 11);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(220, 116);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(213)))), ((int)(((byte)(207)))));
            this.TitleBarPanel.Controls.Add(this.BtnExit);
            this.TitleBarPanel.Controls.Add(this.lblTitleChildForm);
            this.TitleBarPanel.Controls.Add(this.iconCurrentChildForm);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(220, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.ShadowDecoration.Parent = this.TitleBarPanel;
            this.TitleBarPanel.Size = new System.Drawing.Size(784, 80);
            this.TitleBarPanel.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Animated = true;
            this.BtnExit.BorderColor = System.Drawing.Color.White;
            this.BtnExit.CheckedState.Parent = this.BtnExit;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.CustomImages.Parent = this.BtnExit;
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(213)))), ((int)(((byte)(207)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(213)))), ((int)(((byte)(207)))));
            this.BtnExit.HoverState.Parent = this.BtnExit;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnExit.Location = new System.Drawing.Point(9, 8);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(213)))), ((int)(((byte)(207)))));
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(22, 22);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Font = new System.Drawing.Font("AdvertisingExtraBold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Snow;
            this.lblTitleChildForm.Location = new System.Drawing.Point(37, 19);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleChildForm.Size = new System.Drawing.Size(681, 40);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "الصفحة الرئيسية";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(213)))), ((int)(((byte)(207)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(112)))));
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(724, 14);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(50, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // FrmMainDragControl
            // 
            this.FrmMainDragControl.TargetControl = this.TitleBarPanel;
            // 
            // FrmMainElipse
            // 
            this.FrmMainElipse.BorderRadius = 10;
            this.FrmMainElipse.TargetControl = this;
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(216)))));
            this.ShadowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShadowPanel.Location = new System.Drawing.Point(220, 80);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.ShadowDecoration.Parent = this.ShadowPanel;
            this.ShadowPanel.Size = new System.Drawing.Size(784, 9);
            this.ShadowPanel.TabIndex = 4;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.PanelDesktop.Controls.Add(this.pictureBox1);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 89);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.ShadowDecoration.Parent = this.PanelDesktop;
            this.PanelDesktop.Size = new System.Drawing.Size(784, 402);
            this.PanelDesktop.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 491);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.ShadowPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Font = new System.Drawing.Font("AdvertisingExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainApp";
            this.Load += new System.EventHandler(this.FrmMainApp_Load);
            this.SideMenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.TitleBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel SideMenuPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel LogoPanel;
        private System.Windows.Forms.PictureBox BtnHome;
        private FontAwesome.Sharp.IconButton BtnReports;
        private FontAwesome.Sharp.IconButton BtnPatientData;
        private Guna.UI2.WinForms.Guna2GradientPanel TitleBarPanel;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Guna.UI2.WinForms.Guna2DragControl FrmMainDragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm FrmMainShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse FrmMainElipse;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelDesktop;
        private Guna.UI2.WinForms.Guna2GradientPanel ShadowPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}