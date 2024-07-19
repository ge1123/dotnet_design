using Dotnet.Design.Domain;
using Dotnet.Design.Domain.Dto;
using Dotnet.Design.Infrastructure.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.Design.Infrastructure.repositories
{
	public class GetPaymentReportRepository : IGetPaymentReportRepository
	{
		private readonly PaymentContext _paymentContext;

		public GetPaymentReportRepository(PaymentContext paymentContext)
		{
			_paymentContext = paymentContext;
		}

		public async Task<List<GetPaymentReportDto>> GetPaymentReportAsync(DateTime start, DateTime end, string code)
		{
			var query = from paymentTransaction in _paymentContext.PaymentTransaction.AsNoTrackingWithIdentityResolution()
						join payment in _paymentContext.Order.AsNoTrackingWithIdentityResolution()
						on new { paymentTransaction.PaymentOrderId, paymentTransaction.FetcProviderCode } equals new { payment.PaymentOrderId, FetcProviderCode = payment.ProviderCode }
						into paymentGroup

						from ipayment in paymentGroup.DefaultIfEmpty()
						join receipt in _paymentContext.Invoice.AsNoTrackingWithIdentityResolution()
						on ipayment.PaymentOrderId equals receipt.PaymentOrderId
						into receiptGroup

						from iReceipt in receiptGroup.DefaultIfEmpty()
						where ipayment.PaymentDate >= start &&
								 ipayment.PaymentDate <= end &&
								 paymentTransaction.FetcProviderCode == code

						select new GetPaymentReportDto
						{
							PaymentDate = ipayment.PaymentDate.ToString("yyyy-MM-dd"),
							DiscountHours = paymentTransaction.DiscountHours,
							DiscountAmount = paymentTransaction.DiscountTotalAmount,
							PaymentAmount = ipayment.PaymentAmount,
							ReceiptTotalAmount = iReceipt.TotalAmount
						};

			return await query.ToListAsync();
		}

	}
}
