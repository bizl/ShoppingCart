namespace MyCompany.Cart.Api
{
    public class Transactions
    {
        public string TransactionNumber { get; set; }
        public int NumberOfPassengers { get; set; }
        public int Domain { get; set; }
        public int AgentId { get; set; }
        public string ReferrerUrl { get; set; }
        public string CreatedDateTime { get; set; }
        public string UserId { get; set; }
        public string SelectedCurrency { get; set; }
        public string ReservationSystem { get; set; }
    }
}
