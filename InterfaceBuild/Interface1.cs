using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRevertCalc
{
    internal interface Interface1
    {
    }
    public interface IPracticeInterface
    {
        string EmpID { get; }
        string EmpName { get; }
        DateTime GetEMPBirthday(string EmpID);
    }
}
