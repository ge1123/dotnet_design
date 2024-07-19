using Dotnet.Design.Domain.entities;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Dotnet.Design.Domain
{
	public class PaymentContext : DbContext
	{
		public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
		{
		}

		public virtual DbSet<PaymentTransaction> PaymentTransaction { get; set; }
		public virtual DbSet<Order> Order { get; set; }
		public virtual DbSet<Invoice> Invoice { get; set; }

	}
}
