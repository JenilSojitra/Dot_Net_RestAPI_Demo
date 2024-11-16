namespace DotNetRestAPIDemo.Helper
{
    public class Response
    {
        public string status { get; set; } = "success";
        public string Message { get; set; } = string.Empty;
        public dynamic data { get; set; } = null;
    }
}
