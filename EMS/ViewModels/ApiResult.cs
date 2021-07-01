namespace EMS.ViewModels
{
    public class ApiResult
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public ApiResult() { }

        public ApiResult(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public ApiResult(bool status, string message, object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
