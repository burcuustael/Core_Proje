using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterRole : IdentityRole<int>
    {
        public const string Writer = "Writer";
        public const string Admin = "Admin";
        public const string Moderator = "Moderator";

    }
}
