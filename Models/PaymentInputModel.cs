namespace ApiApp.Models
{
    public class PaymentInputModel
    {
        public string NameSurname { get; set; }
        public string CartNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
