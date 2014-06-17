using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cybersource.Reports.Rest
{
    public class ReportService
    {
        private readonly string _clientUri;
        private readonly string _demandUri;
        private readonly string _queryUri;

        private readonly string _username;
        private readonly string _password;

        public string MerchantId { get; set; }
        

        public ReportService(string baseUri, string username, string password)
        {
            _clientUri = baseUri + "/DownloadReport/{year}/{month}/{day}/{merchantId}/{reportName}.{reportFormat}";
            _demandUri = baseUri + "/{reportName}Request.do";
            _queryUri = baseUri + "/Query";

            _username = username;
            _password = password;
        }

        #region daily reports

        public async Task<PaymentBatchDetailReport.Report> GetPaymentBatchDetailReport(DateTime date)
        {
            // fetch content
            var content = await GetClientApiReport("PaymentBatchDetailReport", date);

            // deserialize
            return DeserializeReport<PaymentBatchDetailReport.Report>(content);
        }

        public async Task<PaymentEventsReport.Report> GetPaymentEventsReport(DateTime date)
        {
            // fetch content
            var content = await GetClientApiReport("PaymentEventsReport", date);

            // deserialize
            return DeserializeReport<PaymentEventsReport.Report>(content);
        }

        public async Task<PaymentSubmissionDetailReport.Report> GetPaymentSubmissionDetail(DateTime date)
        {
            // fetch content
            var content = await GetClientApiReport("PaymentSubmissionDetailReport", date);

            // deserialize
            return DeserializeReport<PaymentSubmissionDetailReport.Report>(content);
        }

        public async Task<SubscriptionDetailReport.Report> GetSubscriptionDetailReport(DateTime date)
        {
            // fetch content
            var content = await GetClientApiReport("SubscriptionDetailReport", date);

            //deserialize
            return DeserializeReport<SubscriptionDetailReport.Report>(content);
        }

        public async Task<TransactionExceptionDetailReport.Report> GetTransactionExceptionDetailReport(DateTime date)
        {
            // fetch content
            var content = await GetClientApiReport("TransactionExceptionDetailReport", date);

            //deserialize
            return DeserializeReport<TransactionExceptionDetailReport.Report>(content);
        }
        #endregion

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
            return DeserializeReport<TransactionDetailReport.Report>(content);
        }


        private async Task<string> GetClientApiReport(string reportName, DateTime date)
        {
            // build uri
            var uriParts = new
            {
                merchantId = MerchantId,
                reportName = reportName,
                reportFormat = "xml",
                year = date.ToString("yyyy"),
                month = date.ToString("MM"),
                day = date.ToString("dd")
            };

            var client = GetHttpClient();
            var response = await client.GetAsync(_clientUri.FormatWith(uriParts));
            response.EnsureSuccessStatusCode();

            // fetch content
            return await response.Content.ReadAsStringAsync();
        }

        private async Task<string> GetOnDemandReport(string reportName, DateTime date)
        {
            // form data
            var data = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("merchantID", MerchantId),
                new KeyValuePair<string, string>("username", _username),
                new KeyValuePair<string, string>("password", _password),
                new KeyValuePair<string, string>("startDate", date.ToString("yyyy-MM-dd")),
                new KeyValuePair<string, string>("startTime", date.ToString("HH:mm:ss")),
                new KeyValuePair<string, string>("endDate", date.AddDays(1).ToString("yyyy-MM-dd")),
                new KeyValuePair<string, string>("endTime", date.AddDays(1).ToString("HH:mm:ss")),
                new KeyValuePair<string, string>("format", "xml"),
            });

            var client = GetHttpClient();
            var response = await client.PostAsync(_demandUri.FormatWith(new {reportName}), data);
            response.EnsureSuccessStatusCode();

            // fetch content
            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Get configured http cliewnt
        /// </summary>
        /// <returns></returns>
        private HttpClient GetHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = GetCredentials();
            client.Timeout = new TimeSpan(0,0,0,10);

            return client;
        }

        /// <summary>
        /// Get Credential Headers
        /// </summary>
        /// <returns></returns>
        private AuthenticationHeaderValue GetCredentials()
        {
            // basic authentication
            var username = _username;
            var password = _password;
            var credentials = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(
                    String.Format("{0}:{1}", username, password))));

            return credentials;
        }

        /// <summary>
        /// Deserialize XML
        /// </summary>
        /// <typeparam name="TReport"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        private static TReport DeserializeReport<TReport>(string xml) where TReport : class
        {
            // fix namespaces
            xml = FixNamespace(xml);
            var stream = new StringReader(xml);

            // deserialize
            var serializer = new XmlSerializer(typeof(TReport));
            return serializer.Deserialize(stream) as TReport;
        }

        /// <summary>
        /// Correct xml namespace from test servers
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        private static string FixNamespace(string xml)
        {
            return xml.Replace("https://ebctest.cybersource.com/ebctest/reports/dtd", "https://ebc.cybersource.com/ebc/reports/dtd");
        }
    }
}
