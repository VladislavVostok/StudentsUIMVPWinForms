using Microsoft.Extensions.DependencyInjection;
using StudentsUIMVPWinForms.Repositories;
using StudentsUIMVPWinForms.Views;
using StudentsUIMVPWinForms.Repositories;
using StudentsUIMVPWinForms.Presenters;
using System;

namespace StudentsUIMVPWinForms
{
	internal static class Program
	{

		// Главный контейнер DI
		private static ServiceProvider _serviceProvider;

		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			IMainForm view = new MainForm();

			AppDbContext context = new AppDbContext();
			IRepositoryService repositoryService = new StudentRepositoryService(context);			


			new MainPresenter(view, repositoryService);


			//ApplicationConfiguration.Initialize();
			Application.Run((Form)view);
		}
	}
}