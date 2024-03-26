namespace App_Data_ClassLib.Models
{
    public class PhuongThucThanhToan
	{
		public Guid IDPTTT { get; set; }
		public Guid IDHD { get; set; }
		public string TenPhuongThuc { get; set; }
		public virtual HoaDon HoaDons { get; set; }
	}
}
