using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2.Models
{
    public class Instructor
    {
        public int ID { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[RegularExpression(pattern:@"[a-zA-z]{3,}",ErrorMessage = "Name must be caharcter only annd more than 3charcter")]
		[Remote(action: "NameValidation",controller:"Instructor",AdditionalFields = "ID")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Image is required")]
		
		public string Image { get; set; }

        [Required(ErrorMessage = "Adress is required")]
        [StringLength(50,ErrorMessage ="Adress not more than 50 charchter")]
		[AdressValidation]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(3000,20000,ErrorMessage = "Salar between 3000 and 20000")]
        public double Salary { get; set; }

      
		[ForeignKey("Department")]
		[Display(Name="Department")]
		public int DeptID { get; set; }
		public Department? Department { get; set; }

		[ForeignKey("Course")]
		[Display(Name="Course")]
		public int CrsID { get; set; }
		public Course? Course { get; set; }
    }
}
