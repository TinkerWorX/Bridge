using Bridge;

namespace System
{
    [External]
    [Name("Bridge.ULong")]
    [Constructor("Bridge.ULong")]
    public struct UInt64 : IComparable, IComparable<UInt64>, IEquatable<UInt64>, IFormattable
    {
        private UInt64(int i)
        {
        }

        [Name(false)]
        public static readonly ulong MinValue = 0;

        [Name(false)]
        public static readonly  ulong MaxValue = 0;

        [Template("Bridge.ULong.parse({s})")]
        public static ulong Parse(string s)
        {
            return 0;
        }

        [Template("Bridge.ULong.tryParse({s}, {result})")]
        public static bool TryParse(string s, out ulong result)
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

        public int CompareTo(ulong other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(ulong other)
        {
            return false;
        }
    }
}
