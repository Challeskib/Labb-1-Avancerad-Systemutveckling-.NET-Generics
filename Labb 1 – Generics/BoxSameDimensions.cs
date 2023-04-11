using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class BoxSameDimensions : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            if (x.length == y.length && x.height == y.height && x.width == y.width)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hash = obj.length ^ obj.height ^ obj.width;
            return hash.GetHashCode();
        }
    }
}
