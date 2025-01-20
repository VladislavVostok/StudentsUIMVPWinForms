using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsUIMVPWinForms.Models;

namespace StudentsUIMVPWinForms.Repositories
{
    public interface IRepository
    {
        void Add(StudentModel studentModel);
        void Edit(StudentModel studentModel);
        void Delete(int id);
        IEnumerable<StudentModel> GetAll();
        IEnumerable<StudentModel> GetByValue(string value);

    }
}
