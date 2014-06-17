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
        private static string _username;
        private static string _password;

        static void Main(string[] args)
        {
            _username = ConfigurationManager.AppSettings["username"];
            _password = ConfigurationManager.AppSettings["password"];

            Report();

            Console.WriteLine("Hit ENTER to exit...");
            Console.ReadLine();
        }

        static async void Report()
        {
            var reportService = new ReportService("https://ebctest.cybersource.com/ebctest/", _username, _password)
            {
                MerchantId = "ucdavis_jpknoll"
            };

            var yesterday = DateTime.Today - TimeSpan.FromDays(1);
            
            try
            {
                var report = await reportService.GetPaymentSubmissionDetail(yesterday);

                Console.Write(report);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}
