using System;

namespace AsyncVoid
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
