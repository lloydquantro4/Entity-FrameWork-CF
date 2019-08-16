using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_test
{
    class StudentAddress
    {
        [ForeignKey("Student")]
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        //lazy load
        public virtual Student Student { get; set; }
    }
}
