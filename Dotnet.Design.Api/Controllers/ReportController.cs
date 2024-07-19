using Dotnet.Design.Application.Queries.GetPaymentReport;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Design.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReportController : BaseController
	{
		private readonly IMediator _mediator;

		public ReportController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		[Route("payment")]
		public async Task<IActionResult> QueryPayment([FromBody] GetPaymentQuery query)
		{
			return HandleResult(await _mediator.Send(query));

		}
	}
}
