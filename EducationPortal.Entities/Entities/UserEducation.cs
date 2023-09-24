using EducationPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Entities.Entities
{
    public class UserEducation:BaseEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EducationId { get; set; }
        public bool IsJoined { get; set; }
        public User User { get; set; }
        public Education Education { get; set; }
    }
}
