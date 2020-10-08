using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cryptor_ui.Models
{
	public class CrypterModel
	{
		[Required]
		public string message { get; set; }

		[Required]
		public string key { get; set; }
	}
}
