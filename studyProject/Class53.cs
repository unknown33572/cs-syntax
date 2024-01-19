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
            new SignBase() { SignID = 1}
        }
    }
}
