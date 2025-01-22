using StudentsUIMVPWinForms.Repositories;
using StudentsUIMVPWinForms.Views;


namespace StudentsUIMVPWinForms.Presenters
{
	public class MainPresenter
	{
		private IMainForm mainView;
		private readonly IRepositoryService _repository;
		private readonly AppDbContext _appDbContext;

		public MainPresenter(IMainForm mainView, IRepositoryService repository)
		{

			_repository = repository;
			this.mainView = mainView;
			this.mainView.ShowStudentView += ShowStudentView;
		}

		private void ShowStudentView(object sender, EventArgs e)
		{
			IView view = StudentsForm.GetInstance((Form)mainView);  // После SIngelton
			new StudentPresenter(view, _repository);
		}
	}
}

