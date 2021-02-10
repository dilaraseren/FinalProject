using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // temel voidler için başlangıçlar 
    public interface IResult
    {
        bool Success { get; } //okunabilir. set=> yazılabilir 
        string Message { get; }
    }
}
