namespace API.Models
{
    public class TaiKhoan
    {
        public Guid ID { get; set; }
        public string Username  { get; set; }
        public string Password  { get; set; }
        public DateTime NgayTaoTK { get; set; }
        public bool TrangThai { get; set; }
    }
}
