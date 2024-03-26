namespace App_Data_ClassLib.Models
{
	public class GioHang
	{
		public Guid UserID { get; set; }
		public Guid IDSPCT { get; set; }
		public int SoLuongSP { get; set; }
		public float GiaSanPham { get; set; }
		public virtual ICollection<GioHangChiTiet> GioHangChiTiet { get; set; }
		public virtual User Users { get; set; }
	}
}
