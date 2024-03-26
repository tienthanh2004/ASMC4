namespace App_Data_ClassLib.Models
{
    public class User
	{
		public Guid UserID { get; set; }
		public string TenNguoiDung { get; set; }
		public string Matkhau { get; set; }
		public string SoDienThoai { get; set; }
		public string DiaChi { get; set; }

		public string ChucVu { get; set; }
		public virtual ICollection<HoaDon> HoaDons { get; set; }
		public virtual GioHang GioHangs { get; set; }
	}
}
