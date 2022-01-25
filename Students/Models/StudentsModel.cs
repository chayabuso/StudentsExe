using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{

    public class StudentsModel
    {
        public List<StudentsDetails> studentsList { get; set; }
        public class Student
            {
            public string ID { get; set; }
         
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Nullable<System.DateTime> BirthDate { get; set; }
            public string BirthCountry { get; set; }
            public string Gender { get; set; }
            public string Class { get; set; }
            public string QuestionnaireStatus { get; set; }
            public string PersonalPlanStatus { get; set; }
            public string StudentStatus { get; set; }
            public string StudentType { get; set; }
            public string PrevID { get; set; }
        }
    }
}