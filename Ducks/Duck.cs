using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck : IComparable<Duck>
    {

        public override string ToString()
        {
            return $"{Kind}, {Size} cm";
        }
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToComprare)
        {
            if (this.Size > duckToComprare.Size)
                return 1;
            else if (this.Size < duckToComprare.Size)
                return -1;
            else
                return 0;
        }
    }
}
