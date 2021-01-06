using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.models
{
   

        public class Report
        {
            
            public int Report_ID { get; set; }
            public virtual User_Account Report_Request { get; set; }
            public string Report_Description { get; set; }
        }
    
}
