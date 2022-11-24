using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace RailFenceCipher
{
    public class Methods
    {
        public static string Encode(string str, int num)
        {
            if (str == "") return "";

            var skipBottom = num * 2 - 2;
            var skip = skipBottom;
            var slot = 0;
            var j = 1;
            var level = 1;
            var skipTop = 0;
            var k = 0;
            var newNum = num;

            var answer = str[0].ToString();

            for (int i = 0; i < str.Length-1; i++)
            {
                if(slot + skip > str.Length - 1)
                {
                    slot = j;
                    j++;
                    newNum = newNum == 2 ? num : --newNum;
                    skipBottom = newNum * 2 - 2;
                    skipTop += 2;
                    skip = skipBottom;
                    level++;
                    k = 0;
                }
                else
                {
                    skip = level == 1 ? skipBottom : k % 2 != 0 ? skipTop : skipBottom;
                    slot += skip;
                    k++;
                    skip = level == 1 ? skipBottom : k % 2 != 0 ? skipTop : skipBottom;
                }
                answer += str[slot];
            }

            return answer;
        }

        public static string Decode(string str, int num)
        {
            if (str == "") return "";

            char[] answer = new char[str.Length];

            answer[0] = str[0];

            var newNum = num;
            var level = 1;
            var skip = num * 2 - 2;
            var slot = skip;
            var k = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (slot > str.Length - 1)
                {
                    level++;
                    newNum--;
                    skip = level == num ? num * 2 - 2 : newNum * 2 - 2;
                    k++;
                    slot = k;
                }

                answer[slot] = str[i];

                slot += skip;
            }



            return string.Join("", answer);
        }
    }
}
