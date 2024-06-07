namespace Curd_Coventions.Models
{
    public class User
    {
        public Int64 UserId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId {  get; set; }
        public string Password {  get; set; }
        public virtual List<Token> Tokens { get; set; }
    }

}
