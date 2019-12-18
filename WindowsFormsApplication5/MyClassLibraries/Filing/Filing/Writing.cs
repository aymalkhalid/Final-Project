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
        public void WriteLinesGuestLoginIn(string path, string[] guestloginIN)
        {
            using (StreamWriter outputFile = new StreamWriter(path, true))
            {
                foreach (string item in guestloginIN)
                {
                    outputFile.WriteLine(item);
                }
            }

        }
    }
}
