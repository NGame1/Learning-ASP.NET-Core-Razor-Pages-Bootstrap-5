﻿namespace ViewModels.Security
{
	public class Login1ViewModel : object
	{
		public Login1ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Username")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 6,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
		public string? Username { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Password")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify {0}!")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20,
			MinimumLength = 8,
			ErrorMessage = "The string length of {0} should be min. {2} and max {1} chars!")]
		public string? Password { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Remember Me")]
		public bool RememberMe { get; set; }
		// **********
	}
}
