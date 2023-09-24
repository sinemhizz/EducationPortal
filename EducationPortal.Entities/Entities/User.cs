using EducationPortal.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPortal.Entities.Entities
{
    public class User : IdentityUser,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
