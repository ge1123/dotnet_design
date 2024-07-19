namespace Dotnet.Design.Application.Queries.GetPaymentReport
{
	public class GetPaymentResponse
	{
		/// <summary>
		/// 付款日期
		/// </summary>
		public string? PaymentDate { get; set; }

		/// <summary>
		/// 折扣時數
		/// </summary>
		public decimal? DiscountHours { get; set; }

		/// <summary>
		/// 折扣金額
		/// </summary>
		public decimal? DiscountAmount { get; set; }

		/// <summary>
		/// 總金額
		/// </summary>
		public decimal? PaymentAmount { get; set; }

		/// <summary>
		/// 發票金額
		/// </summary>
		public decimal? ReceiptTotalAmount { get; set; }
	}
}
