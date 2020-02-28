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

            Console.WriteLine("-------------------------- Company A -----------------------------");
            Console.WriteLine("\n Triangle Information : ");
            Console.Write("Base : ");
            int triangleBase = Int32.Parse(Console.ReadLine());
            Console.Write("Height : ");
            int triangleHeight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Rectangle Information : ");
            Console.Write("Length : ");
            int rectangleLength = Int32.Parse(Console.ReadLine());
            Console.Write("Breadth : ");
            int rectangleBreadth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Circle Information : ");
            Console.Write("Radius : ");
            int circleRadius = Int32.Parse(Console.ReadLine());

            CompanyA data = new CompanyA(triangleBase,triangleHeight,rectangleBreadth,rectangleLength,circleRadius);

            //Area Calculation Zone

            Triangle tr = new Triangle(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius);
            Rectangle r = new Rectangle(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius);
            Circle cir  = new Circle(triangleBase, triangleHeight, rectangleBreadth, rectangleLength, circleRadius);
           
        }
    }
}
