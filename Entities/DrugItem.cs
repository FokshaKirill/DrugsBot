using System;

namespace Domain.Entities
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class DrugItem : BaseEntity
	{
		public Guid DrugId { get; set; }
		public Guid DrugStoreId { get; set; }
		public decimal Cost { get; set; }
		public int Count { get; set; }


		public DrugItem()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}

}