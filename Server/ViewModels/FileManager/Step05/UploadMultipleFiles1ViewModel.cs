﻿namespace ViewModels.FileManager.Step05
{
	public class UploadMultipleFiles1ViewModel : object
	{
		public UploadMultipleFiles1ViewModel() : base()
		{
		}

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Override If File Exists")]
		public bool OverrideIfFileExists { get; set; }
		// **********

		// **********
		[System.ComponentModel
			.DataAnnotations.Display(Name = "Files")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessage = "You did not specify any files!")]
		public System.Collections.Generic.IList<Microsoft.AspNetCore.Http.IFormFile>? Files { get; set; }
		// **********
	}
}