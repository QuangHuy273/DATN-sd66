namespace API.Models
{
    public class NhaCungCap
    {
        public Guid NhaCungCapID { get; set; }
        public Guid? NguyenLieuID { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public Guid? DiaChiID { get; set; }
        //public virtual DiaChi DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MoTa { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }
    }
}
