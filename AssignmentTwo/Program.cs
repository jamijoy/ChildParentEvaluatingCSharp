using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    public class User
    {
        private string fullName;
        private int age;

        public void setFullName(string name)
        {
            this.fullName = name;
        }
        public string getFullName()
        {
            return fullName;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
    }
    public class Employee : User
    {
        private float salary;
        public void setSalary(float sal)
        {
            this.setAge(Convert.ToInt32(sal));
        }
        public float getSalary()
        {
            return getAge();
        }
    }
    public class Student : User
    {
        private int creditComplete;
        public void setCreditComplete(int credit)
        {
            this.setAge(credit);
        }
        public float getCreditComplete()
        {
            return getAge();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User un = new User();
            un.setFullName("Prottasha");
            un.setAge(22);
            Console.WriteLine("User Class Name and Age Returning : "+un.getFullName()+" >> " + un.getAge());

            Employee emp = new Employee();
            emp.setFullName("Jami");
            emp.setSalary(25);
            Console.WriteLine("Employee Class Name and Age Returning : " + emp.getFullName() + " >> " + emp.getSalary());

            Student st = new Student();
            st.setFullName("Himi");
            st.setCreditComplete(30);
            Console.WriteLine("Student Class Name and Age Returning : " + st.getFullName() + " >> " + st.getAge());
        }
    }
}
