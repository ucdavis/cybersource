using System;
using System.Configuration;
using Cybersource.Soap.Transaction.Xml;

namespace Cybersource.Soap
{
    class Sample
    {
        public static void Main(string[] args)
        {
            GetSubscription("4053614841670176195662");
        }

        private static void CreateOrder()
        {
            var request = new RequestMessage
            {
                ccAuthService = new CCAuthService {run = "true"},
                ccCaptureService = new CCCaptureService {run = "true"},
                merchantReferenceCode = Guid.NewGuid().ToString(),
                merchantID = ConfigurationManager.AppSettings["merchantId"],
                billTo = new BillTo
                {
                    firstName = "John",
                    lastName = "Doe",
                    street1 = "1295 Charleston Road",
                    city = "Mountain View",
                    state = "CA",
                    postalCode = "94043",
                    country = "US",
                    email = "null@cybersource.com",
                    ipAddress = "10.7.111.111"
                },
                card = new Card {accountNumber = "4111111111111111", expirationMonth = "12", expirationYear = "2020"},
                purchaseTotals = new PurchaseTotals {currency = "USD"},
                item = new[]
                {
                    new Item {id = "0", unitPrice = "12.34"},
                    new Item {id = "1", unitPrice = "56.78"}
                }
            };

            using (var client = new TransactionProcessorClient())
            {
                client.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["merchantId"];
                client.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["transactionKey"];

                client.Open();
                var reply = client.runTransaction(request);
                client.Close();
            }
        }

        private static void GetSubscription(string subscriptionId)
        {
            var request = new RequestMessage
            {
                paySubscriptionRetrieveService = new PaySubscriptionRetrieveService()
                {
                    run = "true"
                },
                merchantID = ConfigurationManager.AppSettings["merchantId"],
                merchantReferenceCode = Guid.NewGuid().ToString(),
                purchaseTotals = new PurchaseTotals()
                {
                    currency = "USD"
                },
                recurringSubscriptionInfo = new RecurringSubscriptionInfo()
                {
                    subscriptionID = subscriptionId
                },
            };

            using (var client = new TransactionProcessorClient())
            {
                client.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["merchantId"];
                client.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["transactionKey"];

                client.Open();
                var reply = client.runTransaction(request);
                client.Close();
            }
        }
    }
}
