namespace Dotnet.Design.Domain.entities
{
	public class PaymentTransaction
	{
		/// <summary>
		/// 流水號
		/// </summary>
		public long Sn { get; set; }
		/// <summary>
		/// 檔案編號
		/// </summary>
		public string FileId { get; set; }
		/// <summary>
		/// 帳務日/結帳日
		/// </summary>
		public DateTime BillingDate { get; set; }
		/// <summary>
		/// 遠通場地編號
		/// </summary>
		public string FetcProviderCode { get; set; }
		/// <summary>
		/// 車牌號碼
		/// </summary>
		public string Plate { get; set; }
		/// <summary>
		/// 車種類型
		/// </summary>
		public int Vehicle { get; set; }
		/// <summary>
		/// 是否為身障車
		/// </summary>
		public bool Disability { get; set; }
		/// <summary>
		/// 交易日期
		/// </summary>
		public DateTime EodTime { get; set; }
		/// <summary>
		/// 進場時間
		/// </summary>
		public DateTime ArriveTime { get; set; }
		/// <summary>
		/// 離場時間
		/// </summary>
		public DateTime DepartTime { get; set; }
		/// <summary>
		/// 交易編號
		/// </summary>
		public string OrderId { get; set; }
		/// <summary>
		/// 停管系統繳款編號(DAS)
		/// </summary>
		public string DasPaymentOrderId { get; set; }
		/// <summary>
		/// 交易總金額
		/// </summary>
		public decimal TotoalPrice { get; set; }
		/// <summary>
		/// 停車金額(臨停費用)
		/// </summary>
		public decimal? ParkPrice { get; set; }
		/// <summary>
		/// 充電金額(A)
		/// </summary>
		public decimal? ChargingPrice { get; set; }
		/// <summary>
		/// 折價金額
		/// </summary>
		public decimal? DiscountPrice { get; set; }
		/// <summary>
		/// 折價時數
		/// </summary>
		public decimal? DiscountHours { get; set; }
		/// <summary>
		/// 折抵總金額
		/// </summary>
		public decimal? DiscountTotalAmount { get; set; }
		/// <summary>
		/// 預約編號
		/// </summary>
		public long? ReserveOrderId { get; set; }
		/// <summary>
		/// 預約費用
		/// </summary>
		public int ReservePrice { get; set; }
		/// <summary>
		/// 服務類型(0:臨停/1:月租)
		/// </summary>
		public int ServiceType { get; set; }
		/// <summary>
		/// 支付工具訂單編號
		/// </summary>
		public string PaymentOrderId { get; set; }
		/// <summary>
		/// 折扣代碼
		/// </summary>
		public string DiscountCode { get; set; }
		/// <summary>
		/// 折扣類型
		/// </summary>
		public string DiscountType { get; set; }
		/// <summary>
		/// 行銷導客金額
		/// </summary>
		public decimal? MarketingTotalAmount { get; set; }
		/// <summary>
		/// 行銷導客折抵日期
		/// </summary>
		public DateTime? MarketingDate { get; set; }
	}
}
