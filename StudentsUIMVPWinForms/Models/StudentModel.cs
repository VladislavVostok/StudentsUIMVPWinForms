using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsUIMVPWinForms.Models
{
	public class StudentModel
	{

		[DisplayName("ИД")]
		[Key]
		public int Id { get; set; }

		[DisplayName("Имя")]
		[Required(ErrorMessage = "Имя студента обязательно!")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Имя студента должно быть от 3 до 50 символов!")]
		public string Name { get; set; }

		[DisplayName("Возраст")]
		[Required(ErrorMessage = "Возраст студента обязателен!")]
		public int Age { get; set; }

	}
}
