namespace DataBase
{
    #region Usings
    using System;
    #endregion

    public class UserProfile
    {
        public int UserProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public int ExperienceInYear { get; set; }
        public int ExperienceInMonths { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string ProfilePic { get; set; }
        public string Description { get; set; }
        public string WebsiteLink { get; set; }
        public string TwitterProfileLink { get; set; }
        public string FacebookProfileLink { get; set; }
        public string LinkedInProfileLink { get; set; }

        //TODO: Add List of Recognizations/Awards
        //TODO: Add List of Experties

        public int UserLoginID { get; set; }
        public virtual UserLogin UserLogin { get; set; }
    }
}
