using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace cc
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSTR = Console.ReadLine();
            inputSTR.print();
            DateTime now = DateTime.Now;
            now.convertGregorianToPersianCalender();
            string raha = "raha";//finglish to persian library
            string persianRaha = raha.toFarsi();
            Console.WriteLine(persianRaha);
            // PrintInteger.print(inputSTR);

            Lamborgini lamborgini = new Lamborgini();
            lamborgini.motorStrength();
            Pride pride = new Pride();
            pride.motorStrength();
            BMW bMW = new BMW();
            bMW.motorStrength();

            ICar lamborginiCar = new Lamborgini();
            Console.WriteLine(lamborginiCar.numberOfDoors);
            ICar prideCar = new Pride();
            Console.WriteLine(prideCar.numberOfDoors);
            ICar bmwCar = new BMW();
            Console.WriteLine(bmwCar.numberOfDoors);

            IEnumerable cars = new ArrayList();


            int[] randomNumbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++){
                randomNumbers[i] = random.Next(20);
            }

            foreach(var item in randomNumbers)
            {
                Console.WriteLine(item);
            }

            var list = (from item in randomNumbers where item > 10 orderby item select item).ToList();
            Console.WriteLine("order by");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.Write("count");
            var count = (from item in randomNumbers where item == 2 select item).Count();
            Console.WriteLine(count);
            
            Person firstPerson = new Person(1,"raha","dastan",20);
            Person secondPerson = new Person(2,"hadi","tabatabaie",21);
            Person thirdPerson = new Person(3,"sina","ahmadkhani",22);

            Person[] people = new Person[3];
            people[0] = firstPerson;
            people[1] = secondPerson;
            people[2] = thirdPerson;

            Grades first = new Grades(1,20,19,18);
            Grades second = new Grades(2,17,16,15);
            Grades third = new Grades(3,14,13,12);
            Grades[] grades = new Grades[3];
            grades[0] = first;
            grades[1] = second;
            grades[2] = third;

            var result = from p in people
                 join g in grades
                 on p.id
                 equals g.id
                 select new
                 {
                     name = p.firstName,
                     CSharp = g.CSharp,
                     math = g.math,
                     os = g.os
                 };

            foreach(var student in result){
                Console.WriteLine(student.name);
                Console.WriteLine(student.CSharp);
                Console.WriteLine(student.math);
                Console.WriteLine(student.os);
            }

            var avg = (from grade in grades let avr = (grade.CSharp + grade.math + grade.os) / 3 select avr).ToList();

            foreach (var s in avg){
                Console.WriteLine(s);
            }

        }
    }

    static class PrintInteger{
        public static void print(this string inputSTR){
            try{
                int inputINT = Convert.ToInt32(inputSTR);
                string numberWithComma = String.Format("{0:#,0.####}", inputINT);
                Console.WriteLine(numberWithComma);
            }
            catch(Exception e){
                Console.WriteLine("Enter a number not a string");
                Console.WriteLine(e);
            }
        }

        public static void convertGregorianToPersianCalender(this DateTime date){
            PersianCalendar pc = new PersianCalendar();
            Console.WriteLine(string.Format("{0}/{1}/{2}", pc.GetYear(date), pc.GetMonth(date), pc.GetDayOfMonth(date)));
        }

        public static string toFarsi(this string persianName){
            return "رها";
        }
    }

    public class Lamborgini : ICar{
        public int speed{
            get{
                return 100;
                }
            set{
                speed = value;
            }
        }

        public int numberOfDoors{
            get{
                return 2;
            }
        }

        public int numberOfWindows{
            get{
                return 2;
            }
        }

        public void motorStrength(){
            Console.WriteLine("motor strength is equal to 100");
        }
    }

    public class Pride : ICar{
        public int speed{
            get{
                return 0;
                }
            set{
                speed = value;
            }
        }

        public int numberOfDoors{
            get{
                return 4;
            }
        }

        public int numberOfWindows{
            get{
                return 4;
            }
        }

        public void motorStrength(){
            Console.WriteLine("motor strength is equal to 0");
        }
    }

    public class BMW:ICar{
        public int speed{
            get{
                return 200;
                }
            set{
                speed = value;
            }
        }

        public int numberOfDoors{
            get{
                return 3;
            }
        }

        public int numberOfWindows{
            get{
                return 3;
            }
        }

        public void motorStrength(){
            Console.WriteLine("motor strength is equal to 300");
        }

    }

    public class Person{
        public int id;
        public string firstName;
        public string lastName;
        public int age;

        public Person(int id, string firstName, string lastName, int age){
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }

    public class Grades{
        public int id;
        public int CSharp;
        public int math;
        public int os;

        public Grades(int id,int CSharp,int math, int os){
            this.id = id;
            this.CSharp = CSharp;
            this.math = math;
            this.os = os;
        }
    }

    interface ICar{
        int speed { get; set; }
        int numberOfDoors{get;}
        int numberOfWindows{get;}
        void motorStrength();
    }

}
