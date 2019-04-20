using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFCI
{
     class Employee
    {
        private string username;
        private string password;
        private static Employee getinstance = new Employee();

        public static Employee getInstance()
        {
            return getinstance;
        }

        public void setUserName(string TextBoxvalue)
        {
            username = TextBoxvalue;
        }

        public string getUsername()
        {
            return username;
        }

        public void setPassword(string textBoxvalue)
        {
            password = textBoxvalue;
        }
        public string getpassword()
        {
            return password;
        }
        private Employee()
        {
            
        }
    }
}
