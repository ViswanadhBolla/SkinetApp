namespace WebApi.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode; 
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
            
        }

        

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad Request, you have made",
                401 => "Authorized, You are not",
                404 => "Resource Found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. anger leads to hate. Hate leads to career change",
                _=> null
            };
        }
    }
}
