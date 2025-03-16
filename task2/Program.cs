////using System;

////namespace Class
////{
////    class Student
////    {
////        private string name;
////        private string surname;
////        private string group;
////        private byte point;
////        private bool isGraduated;

////        public Student(string name, string surname, string group, byte point)
////        {
////            this.name = name;
////            this.surname = surname;
////            this.group = group;
////            this.point = point;
////            this.isGraduated = point >= 65;
////        }

////        public void GetInfo()
////        {
////            Console.WriteLine("Ad: " + name);
////            Console.WriteLine("Soyad: " + surname);
////            Console.WriteLine("Qrup: " + group);
////            Console.WriteLine("Nöqtə: " + point);
////            Console.WriteLine("Mezun olub? " + (isGraduated ? "Beli" : "Xeyr"));  
////        }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Student student = new Student("Nermin", "Hüseynova", "Tarix-1", 72);
////            student.GetInfo();
////        }
////    }
////}



//using System;

//namespace Class
//{
//    class Student
//    {
//        private string name;
//        private string surname;
//        private string group;
//        private byte point;
//        private bool isGraduated;

//        public Student(string name, string surname, string group, byte point)
//        {
//            this.name = name;
//            this.surname = surname;
//            this.group = group;
//            this.point = point;
//            this.isGraduated = point >= 65;
//        }

//        public void CheckGraduation()
//        {
//            if (isGraduated)
//            {
//                Console.WriteLine("Telebe mezun olub.");
//            }
//            else
//            {
//                Console.WriteLine("Telebe mezun olmayıb.");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Student student = new Student("Nərmin", "Hüseynova", "Tarix-1", 72);
//            student.CheckGraduation();
//        }
//    }
//}



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


        public void GetDiplomDegree()
        {
            if (point < 65)
            {
                Console.WriteLine("Diplom: Yoxdur");
            }
            else if (point >= 65 && point < 80)
            {
                Console.WriteLine("Diplom: Adi");
            }
            else if (point >= 80 && point < 90)
            {
                Console.WriteLine("Diplom: Şərəf");
            }
            else
            {
                Console.WriteLine("Diplom: Yüksək Şərəf");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nərmin", "Hüseynova", "Tarix-1", 72);
            student.GetDiplomDegree(); 
        }
    }
}
