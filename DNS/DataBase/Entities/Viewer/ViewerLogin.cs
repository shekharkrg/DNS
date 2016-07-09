namespace DataBase
{
    #region usings
    using Shared;
    #endregion

    public class ViewerLogin
    {
        public int ViewerLoginID { get; set; }
        public string ViewerName { get; set; }
        public string ViewerEmail { get; set; }
        public string Avatar { get; set; }
        public LoginType LoginType { get; set; }
    }
}
