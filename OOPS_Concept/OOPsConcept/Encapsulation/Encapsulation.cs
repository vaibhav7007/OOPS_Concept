using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept.Encapsulation
{
    class ConceptEncapsulation
    {
        private string studentName;
        private string studentId;

        public string Data
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public string info
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }
    }
}