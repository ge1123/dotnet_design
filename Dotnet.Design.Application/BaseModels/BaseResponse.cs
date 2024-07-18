using Dotnet.Design.Application.Enums;
using Dotnet.Design.Application.Extensions;

namespace Dotnet.Design.Api.BaseModels
{
	public class BaseResponse<TData>
	{
		public int Code { get; set; } = (int)SystemStatusEnum.Success;
		public string Status { get; set; } = SystemStatusEnum.Success.GetEnumDescription();
		public TData Data { get; set; }

		public BaseResponse(TData data)
		{
			Data = data;
		}

	}
}
