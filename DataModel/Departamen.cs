using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Departamen
    {
        [Key]
        public int id { get; set; }
        public string departamentName { get; set; }
        public string description { get; set; }

        public ICollection<Employee> employees { get; set; }
    }
}
