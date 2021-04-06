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
        private string name_;
        private int age_;
        private double accessNumber_;

        //#######################
        //Constructors
        //#######################
        Person(string name, int age, double accessNumber) {
            name_ = name;
            age_ = age;
            accessNumber_ = accessNumber;
        }

        //#######################
        //Setters & Getters
        //#######################
        string GetName() {
            return name_;
        }

        int GetAge() {
            return age_;
        }

        double GetAcessNum() {
            return accessNumber_;
        }

        //#######################
        //Functions
        //#######################

    }
}
