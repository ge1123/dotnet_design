using Dotnet.Design.Application.Queries.GetPaymentReport;
using Dotnet.Design.Domain.Dto;

namespace Dotnet.Design.Application.Services.Interface
{
	public interface IGetPaymentReportService
	{
		Task<List<GetPaymentReportDto>> GetReportAsync(GetPaymentQuery query);
	}
}
