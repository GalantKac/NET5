using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    public record Record1
    {
        public Record1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int a { get; init; }
        public int b { get; init; }

        public (int,int) ReturnAB()
        {
            return (a, b);
        }
    }

    public record RecordShort(int a, int b);

    public record RecordInternal(int a, int b)
    {
        internal int b { get; init; } = b;
    }
}
