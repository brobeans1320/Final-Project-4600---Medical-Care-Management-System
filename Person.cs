using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_4600___Medical_Care_Management_System
{
    public class Person
    {
        //#######################
        //Data members
        //#######################
        private string firstName, lastName;
        private string dateOfBirth;
        private string username;
        private string password;
        private string email;
        private string phoneNumber;
        private int age_;
        

        //#######################
        //Constructors
        //#######################
       

        //#######################
        //Setters & Getters
        //#######################
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setDateOfBirth(string dob)
        {
            this.dateOfBirth = dob;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string getFirstName() {
            return this.firstName;
        }

        int GetAge() {
            return age_;
        }

        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        //#######################
        //Functions
        //#######################

    }
}
