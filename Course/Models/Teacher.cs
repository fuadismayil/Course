namespace Course.Models
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string DepartmentName { get; set; }
        public string Subject { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }



        //public Teacher(string firstName, string lastName, string username, string departmentName, string subject, DateOnly birthDate, string address, string email, string phone, int password)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.username = username;
        //    this.departmentName = departmentName;
        //    this.subject = subject;
        //    this.birthDate = birthDate;
        //    this.address = address;
        //    this.email = email;
        //    this.phone = phone;
        //    this.password = password;
        //}
        //public Teacher(string firstName, string lastName, string username, string email, string phone, int password)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.username = username;
        //    this.email = email;
        //    this.phone = phone;
        //    this.password = password;
        //}

        //public Teacher(string firstName, string lastName, string username, string email, string subject, DateOnly birthDate)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.username = username;
        //    this.email = email;
        //    this.subject = subject;
        //    this.birthDate = birthDate;
        //}

        //public string GetName() 
        //{
        //    return $"{firstName} {lastName}";
        //}
        //public string GetSubject()
        //{
        //    return $"{subject}";
        //}

        //public string GetTeacher()
        //{
        //    return $"{firstName} {lastName} {email} {username}";
        //}

        //public string GetEmail()
        //{
        //    return $"{email}";
        //}

        //public DateOnly GetBirthDate()
        //{
        //    return birthDate;
        //}

        //public string GetContact()
        //{
        //    return $"{phone} {email}";
        //}
    }
}