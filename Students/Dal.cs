using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Students.Models.StudentsModel;

namespace Students
{
    public class Dal
    {
        EXEEntities db = new EXEEntities();
      
        internal List<StudentsDetails> GetStudents()
        {
            return db.StudentsDetails.ToList();
    //        return db.StudentsDetails.Where(u=>u.ID!=null).Select(u => new Student
    //        {
    //            ID = u.ID,
    //            FirstName = u.FirstName,
    //            LastName = u.LastName,
    //             BirthDate=u.BirthDate,
    //             BirthCountry=u.BirthCountry,
    //             Gender=u.Gender,
    //             Class=u.Class,
    //             QuestionnaireStatus=u.QuestionnaireStatus,
    //             PersonalPlanStatus=u.PersonalPlanStatus,
    //             StudentStatus=u.StudentStatus,
    //             StudentType=u.StudentType,
    //             PrevID=u.PrevID


    //}).ToList();
        }

    }
}