using Microsoft.EntityFrameworkCore;
using StudentsUIMVPWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsUIMVPWinForms.Repositories
{
	public class AppDbContext : DbContext
	{
		public DbSet<StudentModel> Students { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(
				"server=localhost;user=admin;password=shalom***;database=student_app;",
				new MySqlServerVersion(new Version(8, 4, 3)));
		}
	}
}
