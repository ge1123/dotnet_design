using Dotnet.Design.Domain.Dto;

namespace Dotnet.Design.Infrastructure.Repositories.Interface
{
	public interface IGetPaymentReportRepository
	{
		Task<List<GetPaymentReportDto>> GetPaymentReportAsync(DateTime start, DateTime end, string code);
	}
}
