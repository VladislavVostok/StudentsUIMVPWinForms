using StudentsUIMVPWinForms.Repositories;
using StudentsUIMVPWinForms.Views;


namespace StudentsUIMVPWinForms.Presenters
{
	public class MainPresenter
	{
		private IMainForm mainView;
		private readonly AppDbContext _appDbContext;

		public MainPresenter(IMainForm mainView, AppDbContext appDbContext)
		{
			this.mainView = mainView;
			_appDbContext = appDbContext;

			this.mainView.ShowStudentView += ShowStudentView;
		}

		private void ShowStudentView(object sender, EventArgs e)
		{

			IView view = new StudentsForm();         //Сначала форма каждый вызов новый инстанс
			//IView view = StudentForm.GetInstance((IMainForm)mainView);  // После SIngelton
			IRepository repository = new StudentRepository(_appDbContext);
			new StudentPresenter(view, repository);
		}
	}
}

