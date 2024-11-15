using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CoffeeCampus.Pages.Account
{
	public class LoginModel : PageModel
	{
		[BindProperty]
		public Credential Credential { get; set; }
		public void OnGet()
		{
		}
	}
	public class Credential
	{
		[BindProperty]
		[Required]
		public string UserName { get; set; }
		[BindProperty]
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}