using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class handlecls
    {
     public static bool checkNumber(string a)
        {
            foreach (char c in a)
            {
                if (Char.IsDigit(c) || c=='.' )
                {
                    return true;
                }
            }
            return false;
        }
        public static String GiaiPT(int a, int b)
        {
            Double x = 0.0f;
            if (a == 0)
            {
                if(b==0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }
            else
            {
                x = -b / a;
                return x.ToString();
            }
            
        }
    }

}
