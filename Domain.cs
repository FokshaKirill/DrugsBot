using System;

namespace Domain
{
	/// <summary>
	/// 
	/// </summary>
	public class Domain
	{
		//
		// Идентификатор
		//
		public Guid Id { get; protected set; }

		protected bool Equals(object? obj)
		{
			//TODO: Переопределить так, чтобы в сравнении был ID



			//if (obj is null) return false;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		//TODO: Переопределить операторы != и ==
	}
}
