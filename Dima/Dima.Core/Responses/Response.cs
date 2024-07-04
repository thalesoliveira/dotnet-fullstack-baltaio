using System.Text.Json.Serialization;

namespace Dima.Core.Responses;

public class Response<TData>
{
    
    private readonly int _code;

    //Parameterless
    [JsonConstructor]
    public Response()
    => _code = Configuration.DefaultStatusCode; //Expression Body
    

    public Response(
        TData? data, 
        int code = Configuration.DefaultStatusCode, 
        string? message = null)
    {
        Data = data;
        Message = message;
        _code = code;
    }
    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public bool IsSucess => _code is >= Configuration.DefaultStatusCode and <= Configuration.DefaultStatusCodeEnd;
}