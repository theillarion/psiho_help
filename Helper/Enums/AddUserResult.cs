﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xk7.Helper.Enums
{
    public enum AddUserResult
    {
        Unknown,
        Success,
        UserExists,
        UserAlreadyExists,
        DatabaseError,
        InvalidUsername,
        InvalidPassword,
    }
}
