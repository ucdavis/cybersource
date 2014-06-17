﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Cybersource.Reports.Rest
{
    class Sample
    {
        private const string BaseUri = "https://ebctest.cybersource.com/ebctest/DownloadReport/{year}/{month}/{day}/{merchantId}/{reportName}.{reportFormat}";

        private const string QueryUri = "https://ebctest.cybersource.com/ebctest/Query";

        private const string BaseNamespace = "https://ebctest.cybersource.com/ebctest/reports/dtd";

        static void Main(string[] args)
        {
            StaticReport();
            QueryReport();

            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        static async void StaticReport()
        {
            // uri construction
            var yesterday = DateTime.Today - TimeSpan.FromDays(1);
            var uriParts = new
            {
                merchantId = "ucdavis_jpknoll",
                reportName = "PaymentEventsReport",
                reportFormat = "xml",
                year = yesterday.ToString("yyyy"),
                month = yesterday.ToString("MM"),
                day = yesterday.ToString("dd")
            };

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = GetCredentials();

            try 
            { 
                var response = await client.GetAsync(BaseUri.FormatWith(uriParts));

                response.EnsureSuccessStatusCode();

                var fixRootNs = new XmlRootAttribute { ElementName = "Report", Namespace = BaseNamespace + "/per_1_2.dtd", IsNullable = true };

                var stream = await response.Content.ReadAsStreamAsync();
                var factory = new XmlSerializerFactory();
                var serializer = factory.CreateSerializer(typeof (PaymentEventsReport.Report), fixRootNs);
                var report = serializer.Deserialize(stream) as PaymentEventsReport.Report;

                Console.Write(report);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        static async void QueryReport()
        {
            // form data
            var data = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("merchantID", "ucdavis_jpknoll"),
                new KeyValuePair<string, string>("type", "transaction"),
                new KeyValuePair<string, string>("subtype", "transactionDetail"),
                new KeyValuePair<string, string>("requestID", "4029572250300176056442"),
                new KeyValuePair<string, string>("versionNumber", "1.5")
            });

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = GetCredentials();

            try
            {
                var response = await client.PostAsync(QueryUri, data);

                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private static AuthenticationHeaderValue GetCredentials()
        {
            // basic authentication
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];
            var credentials = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(
                    String.Format("{0}:{1}", username, password))));

            return credentials;
        }
    }
}
