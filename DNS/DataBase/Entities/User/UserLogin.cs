namespace DataBase
{
    public class UserLogin
    {
        public int UserLoginID { get; set; }
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public int UserRoleID { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
