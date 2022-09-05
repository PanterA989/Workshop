using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.Enums
{
    /// <summary>
    /// Flags of errors.
    /// </summary>
    [Flags]
    public enum Errors
    {
        None = 0,
        IsEmpty = 1 << 0,
        TooManyChars = 1 << 1,
        BadFormat = 1 << 2,
        EndBeforeStart = 1 << 3,
        StartFromFuture = 1 << 4,
        BadStatus = 1 << 5,
        Additional2 = 1 << 6,
        Additional3 = 1 << 7
    }
}
