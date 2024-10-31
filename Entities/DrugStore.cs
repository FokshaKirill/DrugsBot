using System;
using Domain.ValueObjects;

namespace Domain.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class DrugStore : BaseEntity
	{
		public string DrugNetwork {  get; set; }
		public int Number {  get; set; }
		public string Name { get; set; }

		public string Street { get; set; }
		public string City { get; set; }
		public string House { get; set; }
		public string PhoneNumber { get; set; }

		public DrugStore()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
