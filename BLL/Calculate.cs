using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Calculate
    {
        public bool IsYear = true;
        public bool bdwinter = true;
        public User Calcby { get;  set; }
        public bool Calculation (Calculate User)
        {
            if (User.IsYear && User.bdwinter)
                return true;

            return false;
        }
    }
    public class User
    {
        public bool IsYear { get; set; }
        public bool bdwinter { get; set; }
    }
}
