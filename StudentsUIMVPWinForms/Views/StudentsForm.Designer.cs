namespace StudentsUIMVPWinForms.Views
{
	partial class StudentsForm
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
			pnlStudentHeader = new Panel();
			lbHeaderStudent = new Label();
			tpcAllStudent = new TabControl();
			tbpAllStudents = new TabPage();
			tbpForms = new TabPage();
			panel2 = new Panel();
			bntEditStudentView = new Button();
			bntAddStudentView = new Button();
			btnSaveStudentView = new Button();
			btnDeleteStudentView = new Button();
			btnCloseStudentView = new Button();
			btnCancelStudentView = new Button();
			dataGridView1 = new DataGridView();
			btnSearch = new Button();
			dataGridView2 = new DataGridView();
			txtSearchBox = new TextBox();
			lbId = new Label();
			lbName = new Label();
			lbAge = new Label();
			txtStudentID = new TextBox();
			txtStudentAge = new TextBox();
			txtStudentName = new TextBox();
			pnlStudentHeader.SuspendLayout();
			tpcAllStudent.SuspendLayout();
			tbpAllStudents.SuspendLayout();
			tbpForms.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// pnlStudentHeader
			// 
			pnlStudentHeader.Controls.Add(txtSearchBox);
			pnlStudentHeader.Controls.Add(btnSearch);
			pnlStudentHeader.Controls.Add(btnCloseStudentView);
			pnlStudentHeader.Controls.Add(lbHeaderStudent);
			pnlStudentHeader.Dock = DockStyle.Top;
			pnlStudentHeader.Location = new Point(0, 0);
			pnlStudentHeader.Name = "pnlStudentHeader";
			pnlStudentHeader.Size = new Size(800, 54);
			pnlStudentHeader.TabIndex = 0;
			// 
			// lbHeaderStudent
			// 
			lbHeaderStudent.AutoSize = true;
			lbHeaderStudent.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			lbHeaderStudent.Location = new Point(12, 9);
			lbHeaderStudent.Name = "lbHeaderStudent";
			lbHeaderStudent.Size = new Size(119, 28);
			lbHeaderStudent.TabIndex = 0;
			lbHeaderStudent.Text = "СТУДЕНТЫ";
			// 
			// tpcAllStudent
			// 
			tpcAllStudent.Controls.Add(tbpAllStudents);
			tpcAllStudent.Controls.Add(tbpForms);
			tpcAllStudent.Dock = DockStyle.Left;
			tpcAllStudent.Location = new Point(0, 54);
			tpcAllStudent.Name = "tpcAllStudent";
			tpcAllStudent.SelectedIndex = 0;
			tpcAllStudent.Size = new Size(659, 396);
			tpcAllStudent.TabIndex = 1;
			// 
			// tbpAllStudents
			// 
			tbpAllStudents.Controls.Add(dataGridView2);
			tbpAllStudents.Controls.Add(dataGridView1);
			tbpAllStudents.Location = new Point(4, 24);
			tbpAllStudents.Name = "tbpAllStudents";
			tbpAllStudents.Padding = new Padding(3);
			tbpAllStudents.Size = new Size(651, 368);
			tbpAllStudents.TabIndex = 0;
			tbpAllStudents.Text = "Список студентов";
			tbpAllStudents.UseVisualStyleBackColor = true;
			// 
			// tbpForms
			// 
			tbpForms.Controls.Add(txtStudentName);
			tbpForms.Controls.Add(txtStudentAge);
			tbpForms.Controls.Add(txtStudentID);
			tbpForms.Controls.Add(lbAge);
			tbpForms.Controls.Add(lbName);
			tbpForms.Controls.Add(lbId);
			tbpForms.Controls.Add(btnCancelStudentView);
			tbpForms.Controls.Add(btnSaveStudentView);
			tbpForms.Location = new Point(4, 24);
			tbpForms.Name = "tbpForms";
			tbpForms.Padding = new Padding(3);
			tbpForms.Size = new Size(651, 368);
			tbpForms.TabIndex = 1;
			tbpForms.Text = "Студент";
			tbpForms.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(btnDeleteStudentView);
			panel2.Controls.Add(bntAddStudentView);
			panel2.Controls.Add(bntEditStudentView);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(655, 54);
			panel2.Name = "panel2";
			panel2.Size = new Size(145, 396);
			panel2.TabIndex = 2;
			// 
			// bntEditStudentView
			// 
			bntEditStudentView.FlatAppearance.BorderSize = 0;
			bntEditStudentView.FlatStyle = FlatStyle.Flat;
			bntEditStudentView.Location = new Point(0, 67);
			bntEditStudentView.Name = "bntEditStudentView";
			bntEditStudentView.Size = new Size(145, 37);
			bntEditStudentView.TabIndex = 0;
			bntEditStudentView.Text = "Изменить";
			bntEditStudentView.UseVisualStyleBackColor = true;
			// 
			// bntAddStudentView
			// 
			bntAddStudentView.FlatAppearance.BorderSize = 0;
			bntAddStudentView.FlatStyle = FlatStyle.Flat;
			bntAddStudentView.Location = new Point(0, 24);
			bntAddStudentView.Name = "bntAddStudentView";
			bntAddStudentView.Size = new Size(145, 37);
			bntAddStudentView.TabIndex = 0;
			bntAddStudentView.Text = "Добавить";
			bntAddStudentView.UseVisualStyleBackColor = true;
			// 
			// btnSaveStudentView
			// 
			btnSaveStudentView.Location = new Point(83, 270);
			btnSaveStudentView.Name = "btnSaveStudentView";
			btnSaveStudentView.Size = new Size(145, 37);
			btnSaveStudentView.TabIndex = 0;
			btnSaveStudentView.Text = "Сохранить";
			btnSaveStudentView.UseVisualStyleBackColor = true;
			// 
			// btnDeleteStudentView
			// 
			btnDeleteStudentView.FlatAppearance.BorderSize = 0;
			btnDeleteStudentView.FlatStyle = FlatStyle.Flat;
			btnDeleteStudentView.Location = new Point(0, 110);
			btnDeleteStudentView.Name = "btnDeleteStudentView";
			btnDeleteStudentView.Size = new Size(145, 37);
			btnDeleteStudentView.TabIndex = 0;
			btnDeleteStudentView.Text = "Удалить";
			btnDeleteStudentView.UseVisualStyleBackColor = true;
			// 
			// btnCloseStudentView
			// 
			btnCloseStudentView.BackColor = Color.Red;
			btnCloseStudentView.FlatAppearance.BorderSize = 0;
			btnCloseStudentView.FlatStyle = FlatStyle.Flat;
			btnCloseStudentView.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
			btnCloseStudentView.Location = new Point(751, 5);
			btnCloseStudentView.Name = "btnCloseStudentView";
			btnCloseStudentView.Size = new Size(37, 39);
			btnCloseStudentView.TabIndex = 1;
			btnCloseStudentView.Text = "X";
			btnCloseStudentView.UseVisualStyleBackColor = false;
			// 
			// btnCancelStudentView
			// 
			btnCancelStudentView.Location = new Point(353, 270);
			btnCancelStudentView.Name = "btnCancelStudentView";
			btnCancelStudentView.Size = new Size(145, 37);
			btnCancelStudentView.TabIndex = 0;
			btnCancelStudentView.Text = "Отменить";
			btnCancelStudentView.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(645, 362);
			dataGridView1.TabIndex = 0;
			// 
			// btnSearch
			// 
			btnSearch.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
			btnSearch.FlatStyle = FlatStyle.Flat;
			btnSearch.Location = new Point(529, 12);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(111, 30);
			btnSearch.TabIndex = 1;
			btnSearch.Text = "Поиск";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Dock = DockStyle.Fill;
			dataGridView2.Location = new Point(3, 3);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(645, 362);
			dataGridView2.TabIndex = 2;
			// 
			// txtSearchBox
			// 
			txtSearchBox.Location = new Point(182, 17);
			txtSearchBox.Name = "txtSearchBox";
			txtSearchBox.Size = new Size(326, 23);
			txtSearchBox.TabIndex = 2;
			// 
			// lbId
			// 
			lbId.AutoSize = true;
			lbId.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
			lbId.Location = new Point(83, 81);
			lbId.Name = "lbId";
			lbId.Size = new Size(35, 21);
			lbId.TabIndex = 1;
			lbId.Text = "ИД";
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
			lbName.Location = new Point(83, 124);
			lbName.Name = "lbName";
			lbName.Size = new Size(44, 21);
			lbName.TabIndex = 1;
			lbName.Text = "Имя";
			// 
			// lbAge
			// 
			lbAge.AutoSize = true;
			lbAge.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
			lbAge.Location = new Point(83, 167);
			lbAge.Name = "lbAge";
			lbAge.Size = new Size(72, 21);
			lbAge.TabIndex = 1;
			lbAge.Text = "Возраст";
			// 
			// txtStudentID
			// 
			txtStudentID.Location = new Point(172, 83);
			txtStudentID.Name = "txtStudentID";
			txtStudentID.Size = new Size(326, 23);
			txtStudentID.TabIndex = 3;
			// 
			// txtStudentAge
			// 
			txtStudentAge.Location = new Point(172, 169);
			txtStudentAge.Name = "txtStudentAge";
			txtStudentAge.Size = new Size(326, 23);
			txtStudentAge.TabIndex = 4;
			// 
			// txtStudentName
			// 
			txtStudentName.Location = new Point(172, 126);
			txtStudentName.Name = "txtStudentName";
			txtStudentName.Size = new Size(326, 23);
			txtStudentName.TabIndex = 5;
			// 
			// StudentsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel2);
			Controls.Add(tpcAllStudent);
			Controls.Add(pnlStudentHeader);
			Name = "StudentsForm";
			Text = "StudentsForm";
			pnlStudentHeader.ResumeLayout(false);
			pnlStudentHeader.PerformLayout();
			tpcAllStudent.ResumeLayout(false);
			tbpAllStudents.ResumeLayout(false);
			tbpForms.ResumeLayout(false);
			tbpForms.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlStudentHeader;
		private Label lbHeaderStudent;
		private TabControl tpcAllStudent;
		private TabPage tbpAllStudents;
		private TabPage tbpForms;
		private Panel panel2;
		private Button bntEditStudentView;
		private Button btnCloseStudentView;
		private Button btnSaveStudentView;
		private Button btnDeleteStudentView;
		private Button bntAddStudentView;
		private Button btnCancelStudentView;
		private Button btnSearch;
		private DataGridView dataGridView2;
		private DataGridView dataGridView1;
		private TextBox txtSearchBox;
		private Label lbAge;
		private Label lbName;
		private Label lbId;
		private TextBox txtStudentName;
		private TextBox txtStudentAge;
		private TextBox txtStudentID;
	}
}