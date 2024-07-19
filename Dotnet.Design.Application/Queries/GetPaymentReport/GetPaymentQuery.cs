using MediatR;

namespace Dotnet.Design.Application.Queries.GetPaymentReport
{
	public class GetPaymentQuery : IRequest<List<GetPaymentResponse>>
	{
		/// <summary>
		/// 起始日期
		/// </summary>
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// 迄止日期
		/// </summary>
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// 代碼
		/// </summary>
		public string? Code { get; set; }
	}
}
