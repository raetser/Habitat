namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class Result<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}