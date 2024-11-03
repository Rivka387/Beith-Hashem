namespace beith_hashem.DTO
{
    public enum AttendanceFrequency { Daily = 1,Often = 2, Holidays = 4, Saturdays = 8 }
    public enum PaymentMethod { Cash, Check, Credit_card, Bank_transfer }
    public class Member
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public string Address { get; set; }
        public double DonatioAmount { get; set; }
        public int FamiltSize { get; set; }
        public AttendanceFrequency Status { get; set; }
        public double TotalDonationsAmount { get; set; }
        public PaymentMethod payment { get; set; }

    }
}
