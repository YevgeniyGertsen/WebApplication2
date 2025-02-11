using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    //public class Message
    //{
    //    [Required(ErrorMessage = "Please enter your name")]
    //    [NameValidate(NotAllowed = new string[] { "Osama Bin Laden", "Saddam Hussain"}, 
    //        ErrorMessage = "You cannot apply for the Job")]
    //    public string name { get; set; }

    //    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", 
    //        ErrorMessage = "E-mail is not valid")]
    //    //[DataType(DataType.EmailAddress, ErrorMessage = "The email address is incorrect.")]
    //    public string email { get; set; }
    //    public string message { get; set; }

    //    //[CustomDate]
    //    [Remote("ValidateDate", "Home")]
    //    public DateTime DOB { get; set; }

    //    public string City { get; set; }
    //}

    //public class Message
    //{
    //    [Required(ErrorMessage = "The field must not be empty")]
    //    [NameValidate(NotAllowed = new string[]
    //    { "Osama Bin Laden",
    //        "Saddam Hussain",
    //        "Mohammed Gaddafi" },
    //        ErrorMessage = "You cannot apply for the Job")]
    //    public string name { get; set; }

    //    [Required(ErrorMessage = "The field must not be empty")]
    //    [EmailAddress(ErrorMessage = "The email address is entered incorrectly")]
    //    public string email { get; set; }

    //    public string message { get; set; }

    //    [CustomDate]
    //    public DateTime DOB { get; set; }
    //    public string City { get; set; }
    //}

    public class Message
    {
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
    }
}
