using System.ComponentModel;

namespace JCommon.ErrorHandling;

[Description("An object for returning errors to the end user."), Category("Error Handling")]
public class Error
{
    public string Message { get; set; }
    public int Code { get; set; }

    public Error(string message)
    {
        Message = message;
    }
    
    public Error(string message, int code)
    {
        Message = message;
        Code = code;
    }
}