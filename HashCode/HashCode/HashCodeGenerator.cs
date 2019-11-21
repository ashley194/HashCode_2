using System.Security.Cryptography;
using System.Text;

namespace HashCode

//Description: Generates the BACS Hash Code using SHA-256 encryption
{
    class HashCodeGenerator
    {
        private string _originatorSortCode;
        private string _recipientSortCode;
        private string _bacsRandomString;
        private string _paymentValue;
        private string _randomNumber;
        private string _seed = "";
        public bool generatorValid;

        public HashCodeGenerator(string originatorSortCode, string recipientSortCode, string paymentValue, string randomNumber, string bacsRandomString)
        {
            _originatorSortCode = originatorSortCode;
            _recipientSortCode = recipientSortCode;
            _paymentValue = paymentValue;
            _randomNumber = randomNumber;
            _bacsRandomString = bacsRandomString;

            CheckValidityAndBuildSeed();
        }
        public string GetSHA256()
        {
            if (!generatorValid)
            {
                return "Invalid sort codes or payment value";
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(_seed.ToString()));

                return BytesToString(hash);
            }
        }
        private void CheckValidityAndBuildSeed()
        {
            generatorValid = false;

            int testInt;

            if (!int.TryParse(_originatorSortCode, out testInt))
            {
                return;
            }

            _seed += (double)testInt;

            if (!int.TryParse(_recipientSortCode, out testInt))
            {
                return;
            }

            _seed += (double)testInt;

            double testDbl;

            if (!double.TryParse(_paymentValue, out testDbl))
            {
                return;
            }
            _seed = _randomNumber + _originatorSortCode + _recipientSortCode + FormattedPaymentValue();

            generatorValid = true;
        }
        private string FormattedPaymentValue()
        {
            string zeros = "00000000000";

            double paymentValue;

            if (!double.TryParse(_paymentValue, out paymentValue))
            {
                return "";
            }

            paymentValue *= 100;

            string convertedPaymentValue = ((int)paymentValue).ToString();

            convertedPaymentValue = zeros + convertedPaymentValue;

            return convertedPaymentValue.Substring(convertedPaymentValue.Length - 11);
        }
        private string BytesToString(byte[] array)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                builder.Append(array[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}