namespace HomeInbox_EngleanAPI.model
{
    public class ResponseResaultModel<T>
    {
        public T data { get; set; }
        public List<string> ErrorMessage { get; set; }
        public bool Issuccess { get; set; } = true;
        public int total { get; set; }
    }
}
