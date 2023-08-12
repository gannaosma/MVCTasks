using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class CrsResult
    {
        public int ID { get; set; }
        public string Degree { get; set; }

        [ForeignKey("Course")]
        public int CrsID { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Trainee")]
        public int TranieeID { get; set; }
        public Trainee Trainee { get; set; }
    }
}
