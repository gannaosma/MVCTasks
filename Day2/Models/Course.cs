using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Degree { get; set; }
        public double MinDegree { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public Department Department { get; set; }
    }
}
