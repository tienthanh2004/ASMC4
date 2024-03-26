namespace App_Data_ClassLib.Models
{
    public class SanPhamChiTiet
	{
		public Guid IDSPCT { get; set; }
		public Guid IDSP { get; set; }
		public string TenSPCT { get; set; }
		public float GiaSP { get; set; }
		public string LoaiSP { get; set; }
		public int SoLuong { get; set; }
		public Guid MaSale { get; set; }

		public virtual SanPham SanPham { get; set; }
		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
		public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
		public virtual Sale Sales { get; set; }
	}
}
