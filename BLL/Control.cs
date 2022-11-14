using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BLL
{
    public class Control

    {
        private string conn = ConfigurationManager.ConnectionStrings["bll"].ToString();
        string Students;
        string IsYear;
        string bdwinter;

        List<string> StudentList = new List<string>();

    }
    for (int i = 0, i< 0; i++)
     {
        StudentList.Add(i*2);
     }
       Console.WriteLine(StudentList.Count);
}

