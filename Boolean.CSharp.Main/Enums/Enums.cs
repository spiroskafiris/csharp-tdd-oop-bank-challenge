﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Boolean.CSharp.Main.Enums
{
    public enum Transaction
    {
        Withdraw,
        Deposit
    }

    public enum Account
    {
        Current,
        Savings
    }
    
    public enum Branch
    {
        Not_Set,
        Athens,
        London,
        Belgium,
        Prague,
        Mosca
    }

    public enum Overdraft
    {
        None,
        Approved,
        Pending,
        Rejected
    }
}