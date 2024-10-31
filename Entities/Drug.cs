using System;

namespace Domain.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Drug : BaseEntity
	{
		public string Date { get; set; }
		public string Manufacturer { get; set; }
		public string CountryCodeId { get; set; }

		public Drug()
		{
		}
	}
}