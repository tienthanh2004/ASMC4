namespace App_Data_ClassLib.Models
{
    public class SanPham
	{
		public Guid IDSP { get; set; }
		public string TenSP { get; set; }
		public float GiaSP { get; set; }
		public int SoLuongTon { get; set; }
		public int TrangThai { get; set; }

		public virtual ICollection<SanPhamChiTiet> SanPhamChiTiet { get; set; }
	}
}
