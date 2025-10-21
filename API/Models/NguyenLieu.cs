namespace API.Models
{
    public class NguyenLieu
    {
        public Guid NguyenLieuID { get; set; }
        public string Ten { get; set; }
        public DateTime HanSuDung { get; set; }
        public bool TrangThai { get; set; }
        //public decimal Gia { get; set; }   
        public string MoTa { get; set; }
    }
}
