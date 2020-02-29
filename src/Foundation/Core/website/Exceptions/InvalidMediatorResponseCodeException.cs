using System;

namespace KATSU.Foundation.Core.Exceptions
{
    public class InvalidMediatorResponseCodeException : Exception
    {
        public InvalidMediatorResponseCodeException(string invalidMediatorCode)
            : base($"{Constants.InvalidMediatorResponse.InvalidCodeReturned}: {invalidMediatorCode}")
        {
        }
    }
}
