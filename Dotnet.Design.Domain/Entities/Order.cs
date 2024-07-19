namespace Dotnet.Design.Domain.entities
{
	public class Order
	{
		/// <summary>
		/// 流水號
		/// </summary>
		public long Sn { get; set; }
		/// <summary>
		/// 帳務日/結帳日
		/// </summary>
		public DateTime? BillingDate { get; set; }
		/// <summary>
		/// 遠通場地編號
		/// </summary>
		public string ProviderCode { get; set; }
		/// <summary>
		/// 停車交易號碼
		/// </summary>
		public string ParkingOrderId { get; set; }
		public string ParkingPaymentOrderId { get; set; }
		/// <summary>
		/// 支付工具訂單編號
		/// </summary>
		public string PaymentOrderId { get; set; }
		/// <summary>
		/// 支付通路
		/// </summary>
		public int PaymentChannel { get; set; }
		/// <summary>
		/// 支付方式
		/// </summary>
		public int PaymentMethod { get; set; }
		/// <summary>
		/// 支付日期
		/// </summary>
		public DateTime PaymentDate { get; set; }
		/// <summary>
		/// 支付金額
		/// </summary>
		public decimal PaymentAmount { get; set; }
		/// <summary>
		/// 支付卡片號碼
		/// </summary>
		public string PaymentCardNo { get; set; }
		/// <summary>
		/// 狀態
		/// </summary>
		public bool PaymentStatus { get; set; }
		/// <summary>
		/// 支付退費金額
		/// </summary>
		public decimal? PaymentRefundAmount { get; set; }
		/// <summary>
		/// 支付退費日期
		/// </summary>
		public DateTime? PaymentRefundDate { get; set; }
		/// <summary>
		/// 發票號碼
		/// </summary>
		public string ReceiptNumber { get; set; }
		/// <summary>
		/// 發票日期
		/// </summary>
		public DateTime? ReceiptDate { get; set; }
		/// <summary>
		/// 資料建立時間
		/// </summary>
		public DateTime CreatedDate { get; set; }
		/// <summary>
		/// 資料更新時間
		/// </summary>
		public DateTime UpdatedDate { get; set; }
		/// <summary>
		/// 第三方支付工具訂單編號
		/// </summary>
		public string ThirdPartyPaymentOrderId { get; set; }
		/// <summary>
		/// 設備編號
		/// </summary>
		public string MachineId { get; set; }
	}
}
