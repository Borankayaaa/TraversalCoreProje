using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About2 // En Alta olan 3 kısımlı yer burayı About2 olarak almayı tercih ettim
    {
        [Key]
        public int About2ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
