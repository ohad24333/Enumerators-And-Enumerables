using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_And__Enumerables
{
    class StudentWhoPracticeALot : IEnumerable<Student>
    {
        public List<Student> students = new List<Student>();

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (Student student in students)
            {
                if(student.Grade>=10) yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
