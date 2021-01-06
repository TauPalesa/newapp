using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.models
{
    public class status
    {

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

