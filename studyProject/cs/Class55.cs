using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class55
    {
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        private String AuthCode;

        public void setAuthcode(string authCode)
        {
            this.AuthCode = authCode;
        }

        public String getAutucode()
        {
            return this.AuthCode;
        }
    }

    class TextToCollection
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\s\Desktop\Dummy\DummyData.txt", System.Text.Encoding.UTF8);
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
