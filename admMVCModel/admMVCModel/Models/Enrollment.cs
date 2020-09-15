using System.ComponentModel.DataAnnotations;

namespace admMVCModel.Models
{
	public enum Grades
	{
		A, B, C, D
	}
	public class Enrollment
	{
		[Key]
		public int EnrollmentID { get; set; }

		public int CourseID { get; set; }

		public int StudentID { get; set; }

		public Grades Grade { get; set; }

		public virtual Course Course { get; set; }
		public virtual Student Student { get; set; }
	}
}