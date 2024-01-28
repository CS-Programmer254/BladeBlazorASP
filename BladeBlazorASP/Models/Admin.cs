namespace BladeBlazorASP.Models
{
    public class Admin
    {
        public Guid AdminID { get; set; }
        public string AdminUserName{ get; set; }
        public string AdminPassword { get; set; }
        public Admin(string adminUserName,string adminPassword)
        {
            AdminID = Guid.NewGuid();
            AdminUserName = adminUserName;
            AdminPassword = adminPassword;
        }
    }
}
