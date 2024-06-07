namespace Curd_Coventions.Models
{
    public class Token
    {
        public Int64 TokenId {  get; set; }
        public string TokenName { get; set; }
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }  
    }
}
