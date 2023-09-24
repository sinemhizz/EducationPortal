using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Core.Entities
{
    public class CustomClientOption
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public List<string> Audiences { get; set; }
    }
}
