using System.Data.Entity;

namespace admMVCModel.Models
{
	public class DataContext : DbContext
	{
		public DataContext() : base("DefaultConnection")
		{

		}

		public System.Data.Entity.DbSet<admMVCModel.Models.Enrollment> Enrollments { get; set; }

		public System.Data.Entity.DbSet<admMVCModel.Models.Course> Courses { get; set; }

		public System.Data.Entity.DbSet<admMVCModel.Models.Student> Students { get; set; }
	}
}