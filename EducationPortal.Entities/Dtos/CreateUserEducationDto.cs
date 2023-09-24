using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Entities.Dtos
{
    public class CreateUserEducationDto
    {
        public string UserId { get; set; }
        public int EducationId { get; set; }
        public bool IsJoined { get; set; }
    }
}
