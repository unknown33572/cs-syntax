using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyProject
{
    class Class53
    {

    }

    class SignBase
    {
        public int SignID { get; set; }
        private string password;
        private String email;

        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getEmail()
        {
            return this.email;
        }
    }

    class SignRepository
    {
        public List<SignBase> GetAll()
        {
            var signs = new List<SignBase>()
            {
                new SignBase() { SignID = 1, Password = "1234" },
                new SignBase() { SignID = 2, Password = "1234" },
                new SignBase() { SignID = 3, Password = "1234" },
            };

            signs[0].setEmail("구글");
            signs[1].setEmail("네이버");
            signs[2].setEmail("다음");

            return signs;
        }
    }

    class SignContext
    {
        public List<SignBase> Signs
        {
            get
            {
                return (new SignRepository()).GetAll();
            }
        }
    }
}
