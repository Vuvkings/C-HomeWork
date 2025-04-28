using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Pracltiks
{
    public class Grade
    {
        public int StudentId { get; set; }
        public string Subject { get; set; }
        public char LetterGrade { get; set; }

        public Grade(int studentId, string subject, char letterGrade)
        {
            StudentId = studentId;
            Subject = subject;
            LetterGrade = letterGrade;
        }
    }
}
