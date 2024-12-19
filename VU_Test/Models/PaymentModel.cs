using System;

namespace VU_Test.Models
{
    public class PaymentModel
    {
        public string Amount { get; set; }
        public string FirstPaymentIncludedInCycle { get; set; } = "True";
        public string ServiceId { get; set; } = "100001";
        public string Currency { get; set; } = "BDT";
        public string StartDate { get; set; }
        public string ExpiryDate { get; set; }
        public string Frequency { get; set; }
        public string SubscriptionType { get; set; } = "BASIC";
        public string MaxCapRequired { get; set; } = "False";
        public string MerchantShortCode { get; set; } = "01307153119";
        public string PayerType { get; set; } = "CUSTOMER";
        public string PaymentType { get; set; } = "FIXED";
        public string RedirectUrl { get; set; }
        public string SubscriptionRequestId { get; set; }
        public string SubscriptionReference { get; set; }
        public string CKey { get; set; } = "000001";


        public static PaymentModel GeneratePaymentModel()
        {
            var random = new Random();
            return new PaymentModel
            {
                Amount = "1",   
                StartDate = DateTime.Now.ToString("yyyy-MM-dd"),   
                ExpiryDate = DateTime.Now.AddDays(random.Next(30, 365)).ToString("yyyy-MM-dd"),   
                Frequency = new[] { "DAILY", "WEEKLY", "MONTHLY" }[random.Next(0, 3)],  
                RedirectUrl = $"https://example.com/{Guid.NewGuid()}",   
                SubscriptionRequestId = Guid.NewGuid().ToString(),  
                SubscriptionReference = "YOUR_PHONE_NUMBER"  
            };
        }
    }
}
