using EducationPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Entities.Entities
{
    public class Education:BaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Teacher { get; set; }
        public int QuatoCount { get; set; }
        public decimal Cost { get; set; }
        public string Time { get; set; }
        public string Content { get; set; }
    }
}
