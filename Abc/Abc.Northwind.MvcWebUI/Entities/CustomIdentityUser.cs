﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Abc.Northwind.MvcWebUI.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        //identityuser'dan gelen proplar dışında custom prop da atayabiliriz.
    }
}
