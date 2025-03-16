using System;

namespace Class
{
    class Student
    {
        private string name;
        private string surname;
        private string group;
        private byte point;
        private bool isGraduated;

        public Student(string name, string surname, string group, byte point)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            this.isGraduated = point >= 65;
        }

        public void GetInfo()
        {
            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Qrup: " + group);
            Console.WriteLine("Nöqtə: " + point);
            Console.WriteLine("Mezun olub? " + (isGraduated ? "Beli" : "Xeyr"));  
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nermin", "Hüseynova", "Tarix-1", 72);
            student.GetInfo();
        }
    }
}
