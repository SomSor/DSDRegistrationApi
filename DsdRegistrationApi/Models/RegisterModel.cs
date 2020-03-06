using System;

namespace DsdRegistrationApi.Models
{
    public class RegisterModel
    {
        public string PID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string LicenseType { get; set; }
        public bool ForPractice { get; set; }
        public bool? ForTestSystem { get; set; }
        public string CourseType { get; set; }
        public int SchoolId { get; set; }
        public string ExamNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ApprovedDateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public DateTime AppointDateTime { get; set; }
        public string QuizLanguage { get; set; }
        public string ApplicationId { get; set; }
        public bool IsListenQuiz { get; set; }
        public string PhoneNumber { get; set; }
    }
}
