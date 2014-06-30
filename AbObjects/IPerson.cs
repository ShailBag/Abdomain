using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AbObjects
{
    public class IPerson
    {
        public int PersonId { get; set; }
        [Required(ErrorMessage="This is a must")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
    }
}
