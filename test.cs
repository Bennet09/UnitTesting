using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class test
    {
        private const int LIMIT = -50;
        private int limitBalance;

        public int LimitBalance { get { return limitBalance; } set { limitBalance = value; } }

        public void checkLimit(int limit)
        {
            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException("limit", limit, "The value was less");
            }
            if (limit > LIMIT)
            {
                throw new ArgumentOutOfRangeException("limit");
            }

        }
    }
}
