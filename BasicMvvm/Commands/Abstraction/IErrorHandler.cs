using System;

namespace BasicMvvm.Commands.Abstraction
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
