using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    public class Test
    {
        public bool IsValid { get; set; }
        public DateTimeOffset TestedOn { get; set; }
        internal void Deconstruct(out int mintesSinceTest, out bool isValid)
        {
            mintesSinceTest = (int)(DateTimeOffset.UtcNow - TestedOn).TotalMinutes;
            isValid = IsValid;
        }
    }

    public class RedTest : Test
    {

    }

    public class GreenTest: Test
    {

    }
}
