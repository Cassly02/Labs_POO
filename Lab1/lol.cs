using System;
using System.Collections.Generic;

namespace MyApplication
{
    class Univer
    {
        private string nameun;
        private int foundYear;
        private List<Student> students = new List<Student>();

        public string getNameUn()
        {
            return this.nameun;
        }
        public int getFoundYear()
        {
            return this.foundYear;
        }
        public List<Student> getStudlist()
        {
            return this.students;
        }
        public void setNameUn(string nameun)
        {
            this.nameun = nameun;
        }
        public void setFoundYear(int foundYear)
        {
            this.foundYear = foundYear;
        }
        public void setStudlist(List<Student> studlist)
        {
            this.students = students;
        }
        public Univer(string nameUn,int FYear, List<Student> students)
        {
            nameun = nameUn;
            foundYear = FYear;
            this.students = students;
        }
        class lol
        {
            static void Main(string[] args)
            {
               
               
                Student st1 = new Student("John Sins", 23, 8.33f);
                Student st2 = new Student("Ricardo Milos", 41, 8.81f);
                Student st3 = new Student("Ghiga Child", 33, 9.03f);
                List<Student> list1 = new List<Student>();
                list1.Add(st1);
                list1.Add(st2);
                list1.Add(st3);
                Univer u1 = new Univer("B.P.Hasdeu.", 1988,list1);

                Console.WriteLine("The First university is " + u1.nameun + " that was found in " + u1.foundYear + " has the following students:\n");
                foreach (var item in list1)
                {
                    Console.WriteLine("\tStudent nr "+item+":\nName: "+item.Namest+"\nAge: "+item.Age+"\nMark: "+item.Mark+"\n");
                }
                double average1 = (st1.Mark + st2.Mark + st3.Mark) / 3;
                Console.WriteLine("***The avarage mark of students from First univ is: "+ Math.Round(average1, 2)+"\n");

                
                
                Student st4 = new Student("Dan Balan", 23, 7.53f);
                Student st5 = new Student("Bob Dilan", 41, 8.92f);
                Student st6 = new Student("Rick Morty", 33, 9.74f);
                List<Student> list2 = new List<Student>();
                list2.Add(st4);
                list2.Add(st5);
                list2.Add(st6);
                Univer u2 = new Univer("U.S.M.", 1992, list2);
                Console.WriteLine("The Second university is " + u2.nameun + " that was found in " + u2.foundYear + " has the following students:\n");
                foreach (var item in list2)
                {
                    Console.WriteLine("\t1st Student:\nName: " + item.Namest + "\nAge: " + item.Age + "\nMark: " + item.Mark + "\n");
                }
                double average2 = (st4.Mark + st5.Mark + st6.Mark) / 3;
                Console.WriteLine("***The avarage mark of students from Second univ is: " + Math.Round(average2, 2)+"\n");
       
                Student st7 = new Student("Gobuto San", 27, 6.59f);
                Student st8 = new Student("Rimuru Tempest", 53, 9.12f);
                Student st9 = new Student("Quasimodo Smelai", 33, 7.93f);
                List<Student> list3 = new List<Student>();
                list3.Add(st7);
                list3.Add(st8);
                list3.Add(st9);
                Univer u3 = new Univer("U.T.M.", 1936,list3);
                Console.WriteLine("The Third university is " + u3.nameun + " that was found in " + u3.foundYear + " has the following students:\n");
                foreach (var item in list3)
                {
                    Console.WriteLine("\t1st Student:\nName: " + item.Namest + "\nAge: " + item.Age + "\nMark: " + item.Mark + "\n");
                }
                double average3 = (st7.Mark + st8.Mark + st9.Mark) / 3;
                Console.WriteLine("***The avarage mark of students from Third univ is: " + Math.Round(average3, 2)+"\n");
                double avMed = (average1 + average2 + average3) / 3;
                Console.WriteLine("***The avarage mark of students from all univ is: " + Math.Round(avMed, 2) + "\n");
            }
        }
    }
    


}


/*
class monitor
{
    public string namest, nameun;
    private int age;
    public fondYear;
        private float mark;
    public student(string ColorName, int DimensionNr, string ResolutionNr)
    {
        Color = ColorName;
        Dimension = DimensionNr;
        Resolution = ResolutionNr;
    }
    public universitate

        static void Main(string[] args)
    {
            car myCar = new car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        monitor m1 = new monitor("Golden", 22, "1901x1680");
        monitor m2 = new monitor("Brown", 32, "1960x1880");
        Console.WriteLine(m1.Color + " " + m1.Dimension + " " + m1.Resolution);
        Console.WriteLine(m2.Color + " " + m2.Dimension + " " + m2.Resolution);

        }
             class vehicle
        {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("tuu tuuu");
        }
        }
        class car : vehicle
        {
            public string modelName = "mustang";
        }
}

*/











