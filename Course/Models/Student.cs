namespace Course.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupNumber { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int Score { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        //public string GetName()
        //{
        //    return $"{firstName} {lastName}";
        //}

        //public string GetGroup()
        //{
        //    return groupNumber;
        //}

        //public string GetStudent()
        //{
        //    return $"{firstName}, {lastName}, {email}, {userName}";
        //}

        //public string GetEmail()
        //{
        //    return email;
        //}

        //public DateOnly GetBirthDate()
        //{
        //    return birthDate;
        //}

        //public string GetContact()
        //{
        //    return $"{phoneNumber}, {email}";
        //}

        //public Student(string inputName, string inputSurname, string inputEmail, string inputPassword, string inputUserName, int inputPhoneNumber, DateOnly inputDate, string inputGroupNumber, int inputScore, string inputAddress)
        //{
        //    firstName = inputName;
        //    lastName = inputSurname;
        //    email = inputEmail;
        //    password = inputPassword;
        //    userName = inputUserName;
        //    phoneNumber = inputPhoneNumber;
        //    birthDate = inputDate;
        //    groupNumber = inputGroupNumber;
        //    score = inputScore;
        //    address = inputAddress;
        //}

        //public Student(string inputName, string inputSurname, string inputEmail, string inputPassword, string inputUserName, int inputPhoneNumber)
        //{
        //    firstName = inputName;
        //    lastName = inputSurname;
        //    email = inputEmail;
        //    password = inputPassword;
        //    userName = inputUserName;
        //    phoneNumber = inputPhoneNumber;
        //}

        //public Student(string inputName, string inputSurname, string inputEmail, string inputPassword, string inputUserName, DateOnly inputDate, string inputGroupNumber)
        //{
        //    firstName = inputName;
        //    lastName = inputSurname;
        //    email = inputEmail;
        //    password = inputPassword;
        //    userName = inputUserName;
        //    birthDate = inputDate;
        //    groupNumber = inputGroupNumber;
        //}
    }
}