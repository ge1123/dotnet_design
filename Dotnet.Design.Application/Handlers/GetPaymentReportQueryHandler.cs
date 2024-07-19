using AutoMapper;
using Dotnet.Design.Application.Queries.GetPaymentReport;
using Dotnet.Design.Application.Services.Interface;
using Dotnet.Design.Domain.Dto;
using MediatR;

namespace Dotnet.Design.Application.Handlers
{
	public class GetPaymentReportQueryHandler : IRequestHandler<GetPaymentQuery, List<GetPaymentResponse>>
	{
		private readonly IGetPaymentReportService _service;
		private readonly IMapper _mapper;

		public GetPaymentReportQueryHandler(IGetPaymentReportService service, IMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		public async Task<List<GetPaymentResponse>> Handle(GetPaymentQuery request, CancellationToken cancellationToken)
		{
			List<GetPaymentReportDto> reportDto = await _service.GetReportAsync(request);
			return _mapper.Map<List<GetPaymentResponse>>(reportDto);
		}
	}
}
