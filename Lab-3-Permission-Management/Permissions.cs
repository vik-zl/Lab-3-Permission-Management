using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    [Flags]   // tells C# this enum can be treated as bit flags
    public enum Permissions
    {
        None = 0,        // 0000
        Read = 1 << 0,   // 0001
        Write = 1 << 1,   // 0010
        Execute = 1 << 2,   // 0100
        Admin = 1 << 3    // 1000
    }
    
}
