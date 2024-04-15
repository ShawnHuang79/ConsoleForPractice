using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRevertCalc
{
    public class Class1 : IPracticeInterface
    {
        public string EmpID { get; private set; }
        public string EmpName { get; private set; }
        public DateTime EmpBirthday { get; private set; }

        // Constructor
        public Class1(string empID, string empName, DateTime empBirthday)
        {
            EmpID = empID;
            EmpName = empName;
            EmpBirthday = empBirthday;
        }

        public DateTime GetEMPBirthday(string EmpID)
        {
            this.EmpID = EmpID + "0";
            return new DateTime();
            //throw new NotImplementedException();
        }
    }
}
