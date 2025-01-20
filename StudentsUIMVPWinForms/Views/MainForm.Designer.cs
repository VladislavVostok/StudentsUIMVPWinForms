namespace StudentsUIMVPWinForms.Views
{
	partial class MainForm
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
			pnlSideMenu = new Panel();
			lbLogo = new Label();
			pnlSideMenuHeader = new Panel();
			btnMainStudent = new Button();
			pnlSideMenu.SuspendLayout();
			pnlSideMenuHeader.SuspendLayout();
			SuspendLayout();
			// 
			// pnlSideMenu
			// 
			pnlSideMenu.Controls.Add(btnMainStudent);
			pnlSideMenu.Controls.Add(pnlSideMenuHeader);
			pnlSideMenu.Dock = DockStyle.Left;
			pnlSideMenu.Location = new Point(0, 0);
			pnlSideMenu.Name = "pnlSideMenu";
			pnlSideMenu.Size = new Size(185, 450);
			pnlSideMenu.TabIndex = 0;
			// 
			// lbLogo
			// 
			lbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			lbLogo.AutoSize = true;
			lbLogo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
			lbLogo.Location = new Point(12, 27);
			lbLogo.Name = "lbLogo";
			lbLogo.Size = new Size(166, 41);
			lbLogo.TabIndex = 0;
			lbLogo.Text = "Менеджер";
			lbLogo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlSideMenuHeader
			// 
			pnlSideMenuHeader.Controls.Add(lbLogo);
			pnlSideMenuHeader.Dock = DockStyle.Top;
			pnlSideMenuHeader.Location = new Point(0, 0);
			pnlSideMenuHeader.Name = "pnlSideMenuHeader";
			pnlSideMenuHeader.Size = new Size(185, 100);
			pnlSideMenuHeader.TabIndex = 0;
			// 
			// btnMainStudent
			// 
			btnMainStudent.Dock = DockStyle.Top;
			btnMainStudent.Location = new Point(0, 100);
			btnMainStudent.Name = "btnMainStudent";
			btnMainStudent.Size = new Size(185, 49);
			btnMainStudent.TabIndex = 1;
			btnMainStudent.Text = "Студенты";
			btnMainStudent.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pnlSideMenu);
			IsMdiContainer = true;
			Name = "MainForm";
			Text = "MainForm";
			pnlSideMenu.ResumeLayout(false);
			pnlSideMenuHeader.ResumeLayout(false);
			pnlSideMenuHeader.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlSideMenu;
		private Button btnMainStudent;
		private Panel pnlSideMenuHeader;
		private Label lbLogo;
	}
}