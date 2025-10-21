namespace API.Models
{
    public class NhanVien
    {
        public Guid NhanVienID { get; set; }
        public Guid? NguoiDungID { get; set; }
        //public virtual NguoiDung NguoiDung { get; set; }
        public Guid? ChucVuId { get; set; }
        //public virtual ChucVu ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public bool TrangThai { get; set; }
    }
}
