﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Users
    {
        public string UserNames { get; set; }
        public string TelPhone { get; set; }
        public string UserPwd { get; set; }

        public Users()
        {

        }

        public bool CheckUserIsValidate() => true;

    }
}
