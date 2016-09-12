namespace DNS.Entities
{
    using Shared;
    public class ViewerLogin
    {
        public int ViewerLoginID { get; set; }
        public string ViewerName { get; set; }
        public string ViewerEmail { get; set; }
        public string Avatar { get; set; }
        public LoginType LoginType { get; set; }
    }
}
