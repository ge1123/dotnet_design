using Dotnet.Design.Application.Queries.GetPaymentReport;
using Dotnet.Design.Application.Services.Interface;
using Dotnet.Design.Domain.Dto;
using Dotnet.Design.Infrastructure.Repositories.Interface;

namespace Dotnet.Design.Application.Services
{
	public class GetPaymentReportService : IGetPaymentReportService
	{
		private readonly IGetPaymentReportRepository _paymentRepository;

		public GetPaymentReportService(IGetPaymentReportRepository getPaymentRepository)
		{
			_paymentRepository = getPaymentRepository;
		}
		public async Task<List<GetPaymentReportDto>> GetReportAsync(GetPaymentQuery query)
		{
			// 取得日結報表資料
			var paymentEODs = await GetPaymentReport(query);

			// 依照日期去計算每日的金額總額, 並且依照日期排序
			var res = paymentEODs.GroupBy(x => x.PaymentDate).Select(group => new GetPaymentReportDto
			{
				PaymentDate = group.Key,
				dayOfWeek = SetDayOfWeek(Convert.ToDateTime(group.Key)),
				DiscountHours = group.Sum(dto => dto.DiscountHours),
				DiscountAmount = group.Sum(dto => dto.DiscountAmount),
				PaymentAmount = group.Sum(dto => dto.PaymentAmount),
				ReceiptTotalAmount = group.Sum(dto => dto.ReceiptTotalAmount)
			}).OrderBy(x => x.PaymentDate).ToList();

			return res;
		}


		private async Task<List<GetPaymentReportDto>> GetPaymentReport(GetPaymentQuery query)
		{
			return await _paymentRepository.GetPaymentReportAsync(query.StartDate.Value, query.EndDate.Value, query.Code);
		}

		/// <summary>
		/// 換算成星期幾
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		private string SetDayOfWeek(DateTime date)
		{
			switch (date.DayOfWeek)
			{
				case DayOfWeek.Monday:
					return "1";
				case DayOfWeek.Tuesday:
					return "2";
				case DayOfWeek.Wednesday:
					return "3";
				case DayOfWeek.Thursday:
					return "4";
				case DayOfWeek.Friday:
					return "5";
				case DayOfWeek.Saturday:
					return "6";
				case DayOfWeek.Sunday:
					return "7";
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}
