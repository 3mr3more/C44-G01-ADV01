using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    internal class BananaRipenessRange<T> where T : IComparable<T>
    {
           T minRipeness { set; get; }
           T maxRipeness { set; get; }


        public bool IsPerfectBanana(T ripeness)
        {
            return ripeness.CompareTo(minRipeness) >= 0 && ripeness.CompareTo(maxRipeness) <= 0;
        }
    }

}
