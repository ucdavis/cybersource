using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Cybersource.Reports.Rest
{
    class Sample
    {
        

        static void Main(string[] args)
        {
            StaticReport();
            QueryReport();

            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        static async void StaticReport()
        {
            var reportService = new ReportService("https://ebctest.cybersource.com/ebctest/")
            {
                Credentials = GetCredentials(),
                MerchantId = "ucdavis_jpknoll"
            };

            var yesterday = DateTime.Today - TimeSpan.FromDays(1);
            
            try
            {
                var report = reportService.GetPaymentEventsReport(yesterday);

                Console.Write(report);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        static async void QueryReport()
        {
            var reportService = new ReportService("https://ebctest.cybersource.com/ebctest/")
            {
                Credentials = GetCredentials(),
                MerchantId = "ucdavis_jpknoll"
            };

            try
            {
                var report = reportService.GetTransactionDetailReport("4029572250300176056442");

                Console.Write(report);
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
