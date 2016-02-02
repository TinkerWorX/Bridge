using Bridge;

namespace System
{
    [External]
    [Name("Bridge.Long")]
    [Constructor("Bridge.Long")]
    public struct Int64 : IComparable, IComparable<Int64>, IEquatable<Int64>, IFormattable
    {
        private Int64(int i)
        {
        }

        [Name(false)]
        public static readonly long MinValue = 0;

        [Name(false)]
        public static readonly  long MaxValue = 0;

        [Template("Bridge.Long.parse({s})")]
        public static long Parse(string s)
        {
            return 0;
        }

        [Template("Bridge.Long.tryParse({s}, {result})")]
        public static bool TryParse(string s, out long result)
        {
            result = 0;
            return false;
        }

        public string ToString(int radix)
        {
            return null;
        }

        public string Format(string format)
        {
            return null;
        }

        public string Format(string format, IFormatProvider provider)
        {
            return null;
        }

        public string ToString(string format)
        {
            return null;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public int CompareTo(long other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(long other)
        {
            return false;
        }
    }
}
