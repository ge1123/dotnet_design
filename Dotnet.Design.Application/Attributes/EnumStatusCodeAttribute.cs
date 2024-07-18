using System.Net;

namespace Dotnet.Design.Application.Attributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class EnumStatusCodeAttribute : Attribute
	{
		public HttpStatusCode HttpStatusCode { get; set; }
		public EnumStatusCodeAttribute(HttpStatusCode httpStatusCode)
		{
			HttpStatusCode = httpStatusCode;
		}
	}
}
