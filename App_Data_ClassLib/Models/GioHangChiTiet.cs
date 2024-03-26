namespace App_Data_ClassLib.Models

{
    public class GioHangChiTiet
	{
		public Guid IDUser { get; set; }
		public Guid IDSPCT { get; set; }
		public int TrangThai { get; set; }
		public virtual GioHang GioHangs { get; set; }

		public virtual SanPhamChiTiet SanPhamChiTiets { get; set; }
	}
}
