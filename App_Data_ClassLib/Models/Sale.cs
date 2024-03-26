namespace App_Data_ClassLib.Models
{
    public class Sale
	{
		public Guid MaSale { get; set; }
		public string TenSale { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public int SoLuong { get; set; }
		public float GiaTri { get; set; }
		public int TrangThai { get; set; }
		public Guid UserID { get; set; }

		public ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
	}
}
