using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pbl.Domain.Auth
{
    public class User: IdentityUser<int>
    {
        public IdentityCard IdentityCard { get; set; }
    }
}
