using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Adress { get; set; }
        public string Grade { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public Department Department { get; set; }

    }
}
