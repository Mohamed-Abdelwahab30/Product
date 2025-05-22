namespace Product.Application.Common
{
    public interface IAppResult
    {
        bool IsSuccess { get; }
        string Message { get; }
        string[] Errors { get; }
        object? Data { get; }
    }
  
        public class AppResult : IAppResult
        {
            public bool IsSuccess { get; private set; }
            public string Message { get; private set; }
            public string[] Errors { get; private set; }
            public object? Data { get; private set; }

            public static AppResult Success(string message = "Success", object? data = null)
                => new() { IsSuccess = true, Message = message, Errors = Array.Empty<string>(), Data = data };

            public static AppResult Failure(params string[] errors)
                => new() { IsSuccess = false, Message = "Failure", Errors = errors };
        }
    }

