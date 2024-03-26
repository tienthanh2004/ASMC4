namespace App_Data_ClassLib.Models
{
    public class HoaDonChiTiet
	{
		public Guid IDHDCT { get; set; }
		public float GiaSP { get; set; }
		public int SoLuong { get; set; }
		public Guid IDHD { get; set; }
		public Guid IDSPCT { get; set; }
		public virtual SanPhamChiTiet SanPhamChiTiets { get; set; }
		public virtual HoaDon HoaDons { get; set; }
	}
}
