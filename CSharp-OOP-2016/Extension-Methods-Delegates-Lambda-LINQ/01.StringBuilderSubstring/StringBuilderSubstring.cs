namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            string errorIndex = "Index should be positive and less than " + sb.Length;
            string errorLength = "Length should be positive and less than " + (sb.Length - index);

            if (index < 0 || index > sb.Length)
            {
                throw new ArgumentOutOfRangeException(errorIndex);
            }

            if (length< 0 || (index + length) > sb.Length)
            {
                throw new ArgumentOutOfRangeException(errorLength);
            }

            return new StringBuilder(sb.ToString().Substring(index,length));
        }
    }
}
