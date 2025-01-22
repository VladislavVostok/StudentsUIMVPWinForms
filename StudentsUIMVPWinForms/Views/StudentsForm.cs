using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsUIMVPWinForms.Views
{
	public partial class StudentsForm : Form, IView
	{
		private string message;
		private bool isSuccessful;
		private bool isEdit;

		public StudentsForm()
		{
			InitializeComponent();
			AssociateAndRaiseViewEvents();
			tpcAllStudent.TabPages.Remove(tbpForms);
		}

		private void AssociateAndRaiseViewEvents()
		{
			btnCloseStudentView.Click += delegate { this.Close(); };


			btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
			txtSearchBox.KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter)
					SearchEvent?.Invoke(this, EventArgs.Empty);
			};

			bntAddStudentView.Click += delegate {
				AddEvent?.Invoke(this, EventArgs.Empty);
				tpcAllStudent.TabPages.Remove(tbpAllStudents);
				tpcAllStudent.TabPages.Add(tbpForms);
				tbpAllStudents.Text = "Добавьте студента";

			};
			bntEditStudentView.Click += delegate {
				EditEvent?.Invoke(this, EventArgs.Empty);
				tpcAllStudent.TabPages.Remove(tbpAllStudents);
				tpcAllStudent.TabPages.Add(tbpForms);
				tbpForms.Text = "Изменить студента";
			};
			btnSaveStudentView.Click += delegate {
				SaveEvent?.Invoke(this, EventArgs.Empty);
				if (isSuccessful)
				{
					tpcAllStudent.TabPages.Remove(tbpForms);
					tpcAllStudent.TabPages.Add(tbpAllStudents);

				}
				MessageBox.Show(Message);
			};
			btnDeleteStudentView.Click += delegate {

				var result = MessageBox.Show("Вы точно хотите удалить выранного студента?", "Внимание!",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					DeleteEvent?.Invoke(this, EventArgs.Empty);
					MessageBox.Show(Message);
				}
			};
			btnCancelStudentView.Click += delegate {

				CancelEvent?.Invoke(this, EventArgs.Empty);
				tpcAllStudent.TabPages.Remove(tbpForms);
				tpcAllStudent.TabPages.Add(tbpAllStudents);

			};

		}

		public string StudentId { get { return txtStudentID.Text; } set => txtStudentID.Text = value; }
		public string Name { get { return txtStudentName.Text; } set => txtStudentName.Text = value; }
		public string Age { get { return txtStudentAge.Text; } set => txtStudentAge.Text = value; }
		public string SearchValue { get { return txtSearchBox.Text; } set => txtSearchBox.Text = value; }
		public bool IsEdit { get { return isEdit; } set => isEdit = value; }
		public bool IsSuccessful { get { return isSuccessful; } set => isSuccessful = value; }
		public string Message { get { return message; } set => message = value; }

		public event EventHandler SearchEvent;
		public event EventHandler AddEvent;
		public event EventHandler EditEvent;
		public event EventHandler DeleteEvent;
		public event EventHandler SaveEvent;
		public event EventHandler CancelEvent;

		public void SetStudentListBindingSource(BindingSource studentList)
		{
			dataGridView1.DataSource = studentList;
		}

		private static StudentsForm instance;
		public static StudentsForm GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new StudentsForm();
				instance.MdiParent = parentContainer;
				instance.FormBorderStyle = FormBorderStyle.None;
				instance.Dock = DockStyle.Fill;
			}
			else
			{
				if (instance.WindowState == FormWindowState.Minimized)
				{
					instance.WindowState = FormWindowState.Normal;
				}
				instance.BringToFront();
			}
			return instance;
		}

	}
}
