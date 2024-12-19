namespace VU_Test.Models
{
    public class InfoJasonModel
    {
        public required string Amount { get; set; }
        public required string FirstPaymentIncludedInCycle { get; set; }
        public required string ServiceId {  get; set; }
        public required string Currency { get; set; }
                       
        public required string StartDate { get; set; }
        public required string ExpiryDate { get; set; }
                       
        public required string Frequency {  get; set; }
        public required string SubscriptionType { get; set; }
                       
        public required string MaxCapRequired { get; set; }
                       
        public required string MerchantShortCode { get; set; }
        public required string PayerType { get; set; }

        public required string PaymentType { get; set; }

        public required string RedirectUrl { get; set; }

        public required string SubscriptionRequestId { get; set; }

        public required string SubscriptionReference { get; set; }

        public required string Ckey { get; set; }

        // this method will give all random value for this model
        public static InfoJasonModel GenerateRandom()
        {
            var random = new Random();

            return new InfoJasonModel
            {
                Amount = random.Next(1, 1000).ToString(),
                FirstPaymentIncludedInCycle = random.Next(0, 2) == 0 ? "True" : "False",
                ServiceId = random.Next(1000, 9999).ToString(),
                Currency = new[] { "BDT", "USD", "EUR" }[random.Next(0, 3)],
                StartDate = DateTime.Now.ToString("yyyy-MM-dd"),
                ExpiryDate = DateTime.Now.AddDays(random.Next(1, 365)).ToString("yyyy-MM-dd"),
                Frequency = new[] { "DAILY", "WEEKLY", "MONTHLY" }[random.Next(0, 3)],
                SubscriptionType = new[] { "BASIC", "PREMIUM", "ENTERPRISE" }[random.Next(0, 3)],
                MaxCapRequired = random.Next(0, 2) == 0 ? "True" : "False",
                MerchantShortCode = random.Next(1000, 9999).ToString(),
                PayerType = new[] { "CUSTOMER", "MERCHANT" }[random.Next(0, 2)],
                PaymentType = new[] { "FIXED", "FLEXIBLE" }[random.Next(0, 2)],
                RedirectUrl = $"https://FR.com/{Guid.NewGuid()}",
                SubscriptionRequestId = Guid.NewGuid().ToString(),
                SubscriptionReference = random.Next(1000, 9999).ToString(),
                Ckey = random.Next(1000, 9999).ToString()
            };
        }
    }
}
