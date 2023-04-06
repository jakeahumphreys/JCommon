using System.ComponentModel;
using JCommon.ErrorHandling;

namespace JCommon.Communication.External;

[Description("A base response class for API communication with error handling."), Category("External Communication")]
public class BaseResponse
{
    public Error Error { get; set; }

    public T WithError<T>(Error error) where T : BaseResponse
    {
        Error = error;

        return (T) this;
    }
}