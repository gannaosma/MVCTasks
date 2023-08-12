using System.ComponentModel.DataAnnotations;

namespace Day2.Models
{
	public class AdressValidation : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			string[] adress = { "Menofia", "Cairo", "Alex" };
			if (adress.Contains(value))
			{
				return ValidationResult.Success;
			}
			return new ValidationResult("Allowed adress Menofia ,Cairo and Alex");
		}
	}
}
