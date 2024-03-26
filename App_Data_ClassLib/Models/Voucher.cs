namespace App_Data_ClassLib.Models
{
    public class Voucher
	{
		public Guid IDVouncher { get; set; }
		public string TenVouncher { get; set; }
		public int SoLuong { get; set; }
		public float GiaTri { get; set; }
		public float DieuKien { get; set; }
		public virtual ICollection<HoaDon> HoaDons { get; set; }
	}
}
