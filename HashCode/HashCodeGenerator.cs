using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class HashCodeGenerator
    {
        private int _originatorSortCode;
        private int _recipientSortCode;
        private string _bacsRandomString;
        private double _paymentValue;
        public bool generatorValid;

        public HashCodeGenerator(string originatorSortCode, string recipientSortCode, string paymentValue)
        {
            generatorValid = false;

            if (!int.TryParse(originatorSortCode, out _originatorSortCode))
            {
                return;
            }

            if (!int.TryParse(recipientSortCode, out _recipientSortCode))
            {
                return;
            }

            if (!double.TryParse(paymentValue, out _paymentValue))
            {
                return;
            }

            generatorValid = true;

        }

        public double SHA256()
        {
            return (double)_originatorSortCode + (double)_recipientSortCode + _paymentValue;
        }
    }
}
