namespace App_Data_ClassLib.Models
{
    public class HoaDon
	{
		public Guid IDHD { get; set; }
		public Guid UserID { get; set; }
		public string DiaChi { get; set; }
		public string SoDienThoai { get; set; }
		public Guid IDSPCT { get; set; }
		public float TongTien { get; set; }
		public DateTime ThoiGianThanhToan { get; set; }
		public Guid IDVouncher { get; set; }
		public int TrangThai { get; set; }
		public Guid IDPTTT { get; set; }

		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
		public virtual User Users { get; set; }
		public virtual Voucher Vounchers { get; set; }
		public virtual ICollection<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
	}
}
