namespace Day1.Models
{

	public static class StudentList
	{
		public static List<Student> Students { get; set; }

		static StudentList()
		{
			Students = new List<Student>();
			Students.Add(new Student() { ID=1, Name="ganna", Address= "damietta", Image = "1.jpg"});
			Students.Add(new Student() { ID=2, Name="Ranna", Address= "damietta", Image = "2.jpg"});
			Students.Add(new Student() { ID=3, Name="Heba", Address= "damietta", Image = "3.jpg"});
		}
	}
}
