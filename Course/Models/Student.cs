namespace Course.Models
{
    public class Student:BaseUser 
    {
        public string GroupNumber { get; set; }
        public int Score { get; set; }
        
    }
}