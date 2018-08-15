using System;
using System.Collections.Generic;
using System.Text;

namespace P01StringBuilderSubstring
{
    public static class ExtensionSubstring
    {
        public static StringBuilder StringBuilderSubstring(this StringBuilder str, int index, int lenght)
        {
            StringBuilder sb = new StringBuilder();

            if (index < 0 || str.Length <= index)
            {
                throw new ArgumentException("Invalid index argument!");
            }
            else if (index + lenght > str.Length || 0 > lenght)
            {
                throw new ArgumentException("Invalid lenght argument!");
            }

            for (int i = index; i < index + lenght; i++)
            {
                sb.Append(str[i]);
            }
            return sb;
        }
    }
}
