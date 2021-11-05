using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    static class StringExtention
    {
        public static string ToName(this string name)
        {
            var newName = Char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return newName;
        }

        public static bool IsName(this string name)
        {
            if(!string.IsNullOrWhiteSpace(name) && name.Length>2  && Char.IsUpper(name[0]))
            {
                for (int i = 1; i < name.Length; i++)
                {
                    if (!Char.IsLower(name[i])) return false;
                }
                return true;
            }
            return false;
        }


    }
}
