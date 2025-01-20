using Microsoft.EntityFrameworkCore;
using StudentsUIMVPWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsUIMVPWinForms.Repositories
{
	public class StudentRepository : BaseRepository, IRepository
	{
		public StudentRepository(AppDbContext dbContext) : base(dbContext)
		{
		}

		public void Add(StudentModel studentModel)
		{
			_dbContext.Students.Add(studentModel);
		}

		public void Delete(int id)
		{
			StudentModel student = _dbContext.Students.FirstOrDefault(p => p.Id == id);

			if (student != null) {
				_dbContext.Students.Remove(student);
			}
		
		}	


		public void Edit(StudentModel studentModel)
		{
			_dbContext.Students.Update(studentModel);
		}

		public IEnumerable<StudentModel> GetAll()
		{
			return _dbContext.Students.ToList();
		}

		public IEnumerable<StudentModel> GetByValue(string value)
		{
			throw new NotImplementedException();
		}
	}
}
