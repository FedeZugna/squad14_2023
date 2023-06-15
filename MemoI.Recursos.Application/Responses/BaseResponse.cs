using System.Text.Json.Serialization;

namespace MemoI.Recursos.Application.Responses;

public class BaseResponse
{
    public string Id { get; set; }
    
    [JsonIgnore]
    public bool Success { get; set; }
    public string Message { get; set; }
    
    public BaseResponse(bool success)
    {
        Success = success;
        Id = string.Empty;
        Message = success ? "Successful" : "Failed";
    }
    
    public BaseResponse(bool success, string id)
    {
        Success = success;
        Id = id;
        Message = success ? "Successful" : "Failed";
    }
    
    public BaseResponse(bool success, string id, string message)
    {
        Success = success;
        Id = id;
        Message = message;
    }
}