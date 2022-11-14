using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAL
{
    [Serializable()]
    public class Student  : ISerializable 
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int YrofStudy { get; set; }
        public string DOB { get; set; }
        public Student() {  }
        public Student(string lastname = "no name",
            string dob = "no dob",
            int yrofstudy = 0)
        { 
            LastName = lastname;
            DOB = dob;
            YrofStudy = yrofstudy;
        }
        public override string ToString()
        {
            return string.Format("{0} was born on {1} and is in their {2} of study",
                LastName, DOB, YrofStudy);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", LastName);
            info.AddValue("DOB", DOB);
            info.AddValue("year", YrofStudy);  
        }
        public Student (SerializationInfo info, StreamingContext context)
        {
            LastName = (string)info.GetValue("Name", typeof(string));
            DOB = (string)info.GetValue("DOB", typeof(string));
            YrofStudy = (int)info.GetValue("year", typeof(int));
        }

    }
}
