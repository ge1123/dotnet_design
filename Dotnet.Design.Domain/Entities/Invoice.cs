namespace Dotnet.Design.Domain.entities
{
	public class Invoice
	{
		/// <summary>
		/// 流水號
		/// </summary>
		public long Sn { get; set; }
		/// <summary>
		/// 停車場交易序號
		/// </summary>
		public string ParkingOrderId { get; set; }
		/// <summary>
		/// 支付工具交易序號
		/// </summary>
		public string PaymentOrderId { get; set; }
		/// <summary>
		/// 設備編號
		/// </summary>
		public string MachineId { get; set; }
		/// <summary>
		/// 發票號碼
		/// </summary>
		public string ReceiptNumber { get; set; }
		/// <summary>
		/// 發票時間
		/// </summary>
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 發票狀態
		/// </summary>
		public string ReceiptStatus { get; set; }
		/// <summary>
		/// 發票作廢狀態
		/// </summary>
		public string ReceiptCancelStatus { get; set; }
		/// <summary>
		/// 發票總金額
		/// </summary>
		public decimal TotalAmount { get; set; }
		/// <summary>
		/// 發票銷售額(移除該欄位)
		/// </summary>
		public decimal SalesAmount { get; set; }
		/// <summary>
		/// 應稅金額
		/// </summary>
		public decimal InTaxAmount { get; set; }
		/// <summary>
		/// 免稅金額
		/// </summary>
		public decimal? FreeTaxAmount { get; set; }
		/// <summary>
		/// 零稅金額
		/// </summary>
		public decimal? ZeroTaxAmount { get; set; }
		/// <summary>
		/// 稅率類型
		/// </summary>
		public string TaxType { get; set; }
		/// <summary>
		/// 稅率
		/// </summary>
		public decimal TaxRate { get; set; }
		/// <summary>
		/// 營業人統一編號
		/// </summary>
		public string SellerEin { get; set; }
		/// <summary>
		/// 買方統一編號
		/// </summary>
		public string BuyerEin { get; set; }
		/// <summary>
		/// 買方名稱
		/// </summary>
		public string BuyerName { get; set; }
		/// <summary>
		/// 列印註記
		/// </summary>
		public bool PrintMark { get; set; }
		/// <summary>
		/// 載具類型
		/// </summary>
		public string CarrierType { get; set; }
		/// <summary>
		/// 載具顯碼
		/// </summary>
		public string CarrierId1 { get; set; }
		/// <summary>
		/// 載具隱碼
		/// </summary>
		public string CarrierId2 { get; set; }
		/// <summary>
		/// 發票隨機碼
		/// </summary>
		public string RandomNumber { get; set; }
		/// <summary>
		/// 捐贈註記
		/// </summary>
		public bool Donatemark { get; set; }
		/// <summary>
		/// 捐贈愛心碼
		/// </summary>
		public string Npoban { get; set; }
		/// <summary>
		/// 發票類型
		/// </summary>
		public string ReceiptType { get; set; }
		/// <summary>
		/// 遠通場地編號
		/// </summary>
		public string ProviderCode { get; set; }
		/// <summary>
		/// 中獎註記
		/// </summary>
		public bool? Lottery { get; set; }
		/// <summary>
		/// 中獎日期
		/// </summary>
		public DateTime? LotteryDate { get; set; }
		/// <summary>
		/// 電話號碼
		/// </summary>
		public string PhoneNumber { get; set; }
		/// <summary>
		/// EOD檔案名稱
		/// </summary>
		public string EodFilename { get; set; }
		/// <summary>
		/// EOD時間
		/// </summary>
		public DateTime? EodDate { get; set; }
		/// <summary>
		/// 加值中心代號
		/// </summary>
		public string CenterId { get; set; }
		/// <summary>
		/// 建立日
		/// </summary>
		public DateTime CreatedDate { get; set; }
		/// <summary>
		/// 更新日
		/// </summary>
		public DateTime UpdatedDate { get; set; }

		/// <summary>
		/// 退回原因
		/// </summary>
		public string ReturnReason { get; set; }
	}
}
