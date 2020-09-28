using API.Controllers;

namespace API.Error
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null,
        string details = null) : base(statusCode, message)
        {
            Desails =details;
        }
        public string Desails { get; set; }
    }
}