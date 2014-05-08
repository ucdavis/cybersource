using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cybersource.Helpers
{
    public static class Security
    {
        private const String SECRET_KEY = "16155faf6d2a4c9a9142223cc0c2f9db30d27b37223e4678b83272d1f3e80a736a8dd11b96f34369b27d9ed139653173d10aae77edc14e03b10a4c7896cfd54e8fc64b47dfa54d56b57fcb6029bd25f7e439d59d01ad4a6885a2fad35195991cf2afaf8c13e8474b88725bc5575690a42f7fc690baae4ac9939a7dfc16bf3207";

        public static String sign(IDictionary<string, string> paramsArray)
        {
            return sign(buildDataToSign(paramsArray), SECRET_KEY);
        }

        private static String sign(String data, String secretKey)
        {
            UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] keyByte = encoding.GetBytes(secretKey);

            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);
            byte[] messageBytes = encoding.GetBytes(data);
            return Convert.ToBase64String(hmacsha256.ComputeHash(messageBytes));
        }

        private static String buildDataToSign(IDictionary<string, string> paramsArray)
        {
            String[] signedFieldNames = paramsArray["signed_field_names"].Split(',');
            IList<string> dataToSign = new List<string>();

            foreach (String signedFieldName in signedFieldNames)
            {
                dataToSign.Add(signedFieldName + "=" + paramsArray[signedFieldName]);
            }

            return commaSeparate(dataToSign);
        }

        private static String commaSeparate(IList<string> dataToSign)
        {
            return String.Join(",", dataToSign);
        }
    }
}
