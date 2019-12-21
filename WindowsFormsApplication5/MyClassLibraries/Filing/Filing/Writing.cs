using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Filing
{
    public class Writing
    {
        public void writeLinesGuestLoginIn(string path, string[] guestloginIN)
        {
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                foreach (string item in guestloginIN)
                {
                    outputFile.WriteLine(item);
                }
            }
        }
            public void writeLinesUserLoginIn(string path, string[] userLoginIn)
        {
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                foreach (string item in userLoginIn)
                {
                    outputFile.WriteLine(item);
                    //1 + 2;
                }
            }
        }
        public static bool IsAllLettersOrDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }
       
    }
}
