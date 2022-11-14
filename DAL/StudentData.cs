using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace DAL
{

    class StudentData
    {
        Student john = new Student("John", "2/01/03", 2);

        Stream stream = File.Open("studentdata", FileMode.Create);

        List<Student> theStudents = new List<Student>
        {
            new Student("mario", "2/12/02", 2),
            new Student("doe", "9/11/03", 2),
            new Student("kiti", "18/5/01", 2),
            new Student("susan", "2/12/02", 2),
            new Student("mary", "5/2/04", 4)
        };
    }
      /*  using(Stream fs =  FileStream(@"C:\Users\princessntomo\C#Data\students.xml"))
        {
           XmlSerializer ser = new XmlSerializer(typeof(list<Student>));
            ser.Serialize(fs, theStudents);
         }

           theStudents = null;
      */

    }

