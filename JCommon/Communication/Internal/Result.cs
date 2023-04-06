using System.ComponentModel;
using JCommon.ErrorHandling;

namespace JCommon.Communication.Internal;

[Description("A wrapper class for returning the results of methods with error handling."), Category("Internal Communication")]
public sealed class Result<T>
{
    public T Content { get; set; }
    public bool IsFailure => Errors.Any();
    public List<Error> Errors { get; set; }

    public Result(T content)
    {
        Errors = new List<Error>();
        Content = content;
    }

    public Result()
    {
        Errors = new List<Error>();
    }
    
    public Result<T> WithError(string message)
    {
        return new Result<T>
        {
            Errors = new List<Error> {new Error(message)}
        };
    }
}