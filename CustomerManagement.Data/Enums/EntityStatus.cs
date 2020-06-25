using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Enums
{
    public enum EntityStatus
    {
        ACTIVE = 1,
        LOCK,
        HIDDEN,
        DELETED = 99
    }
}
