using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            int volumeBox1 = x.height * x.length * x.width;
            int volumeBox2 = y.height * y.length * y.width;


            if (volumeBox1 == volumeBox2)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }
}
