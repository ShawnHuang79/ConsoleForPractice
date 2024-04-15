using NumRevertCalc;

namespace InterfaceBuild
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1("1234", "123", new DateTime());
            class1.GetEMPBirthday(class1.EmpID);
            Console.WriteLine(class1.EmpID);
        }
    }
}
