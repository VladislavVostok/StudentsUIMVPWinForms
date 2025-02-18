﻿using System;
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
	public partial class MainForm : Form, IMainForm
	{
		public MainForm()
		{
			InitializeComponent();

			btnMainStudent.Click += delegate
			{
				ShowStudentView?.Invoke(this, EventArgs.Empty);
			};
		}

		public event EventHandler ShowStudentView;
	}
}
