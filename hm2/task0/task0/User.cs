using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task0
{
    class User
    {
        string login, firstname, secondname;
        int age;
        public readonly DateTime date;
        public User(string login, string firstname, string secondname, int age)
    {
        this.login = login;
        this.firstname = firstname;
        this.secondname = secondname;
        this.age = age;
        this.date = DateTime.Today;
    }

        public void Show()
        {
            Console.WriteLine(login + ' ' + firstname + ' ' + secondname + ' ' + age + ' ' + 
                date);
        }
    }
    
}
