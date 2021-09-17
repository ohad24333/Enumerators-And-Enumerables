using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_And__Enumerables
{
    class PowerNumberClaas : IEnumerable<long>
    {
        int num;
        public PowerNumberClaas(int num)
        {
            this.num = num;
        }

        public IEnumerator<long> GetEnumerator()
        {
            long sum = num;

            for (int i = 1; i < 10; i++)
            {     
                  yield return sum = num * sum;         
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
