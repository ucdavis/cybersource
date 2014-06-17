using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cybersource.Reports.Rest
{
    public class ReportService
    {
        private readonly string _demandUri;

        private readonly string _queryUri;

        public string MerchantId { get; set; }
        public AuthenticationHeaderValue Credentials { get; set; }

        public ReportService(string baseUri)
        {
            _demandUri = baseUri + "/DownloadReport/{year}/{month}/{day}/{merchantId}/{reportName}.{reportFormat}";
            _queryUri = baseUri + "/Query";
        }

        public async Task<TransactionDetailReport.Report> GetTransactionDetailReport(string transactionId)
        {
            // form data
            var data = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("merchantID", MerchantId),
                new KeyValuePair<string, string>("type", "transaction"),
                new KeyValuePair<string, string>("subtype", "transactionDetail"),
                new KeyValuePair<string, string>("requestID", transactionId),
                new KeyValuePair<string, string>("versionNumber", "1.5")
            });

            var client = GetHttpClient();
            var response = await client.PostAsync(_queryUri, data);
            response.EnsureSuccessStatusCode();

            // fetch content
            var content = await response.Content.ReadAsStringAsync();

            // fix namespaces
            content = content.Replace("tdr_1_5.dtd", "tdr_1_13.dtd");

            // deserialize
            return DesearializeReport<TransactionDetailReport.Report>(content);
        }

        public async Task<PaymentEventsReport.Report> GetPaymentEventsReport(DateTime date)
        {
            // build uri
            var uriParts = new
            {
                merchantId = MerchantId,
                reportName = "PaymentEventsReport",
                reportFormat = "xml",
                year = date.ToString("yyyy"),
                month = date.ToString("MM"),
                day = date.ToString("dd")
            };

            var client = GetHttpClient();
            var response = await client.GetAsync(_demandUri.FormatWith(uriParts));
            response.EnsureSuccessStatusCode();

            // fetch content
            var content = await response.Content.ReadAsStringAsync();

            // deserialize
            return DesearializeReport<PaymentEventsReport.Report>(content);
        }

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = Credentials;
            client.Timeout = new TimeSpan(0,0,0,10);

            return client;
        }

        private static TReport DesearializeReport<TReport>(string xml) where TReport : class
        {
            // fix namespaces
            xml = FixNamespace(xml);
            var stream = new StringReader(xml);

            // deserialize
            var serializer = new XmlSerializer(typeof(TReport));
            return serializer.Deserialize(stream) as TReport;
        }

        private static string FixNamespace(string xml)
        {
            return xml.Replace("https://ebctest.cybersource.com/ebctest/reports/dtd", "https://ebc.cybersource.com/ebc/reports/dtd");
        }
    }
}
