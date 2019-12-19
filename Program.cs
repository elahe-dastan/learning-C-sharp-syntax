using System;
using System.Linq;
using System.Collections.Generic;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0,4,34,3,2,3,7,5,3,23};
            var check = numbers.Where(number => number == 2).Any();
            Console.WriteLine(check); 
            var check1 = numbers.Any(number => number == 2);
            Console.WriteLine(check1);
            // var firstSelect = numbers.Where(number => number == 13).First();
            // Console.WriteLine(firstSelect);
            var firstSelectOrDefault = numbers.Where(number => number == 13).FirstOrDefault();
            Console.WriteLine(firstSelectOrDefault);
            // var single = numbers.Where(number => number == 3).Single();
            // Console.WriteLine(single);
            // var singleOrDefault = numbers.Where(number => number == 3).SingleOrDefault();
            // Console.WriteLine(singleOrDefault);

            string[] names = {"raha", "shayan", "hadi", "sina", "nika"};
            var nameWithI = names.Where(name => name.ToLower().Contains("i")).ToList();
            foreach (string n in nameWithI){
                Console.WriteLine(n);
            }
            Console.WriteLine();
            var namesStartingWithS = names.Where(name => name.ToLower().StartsWith("s")).ToList();
            foreach (string n in namesStartingWithS){
                Console.WriteLine(n);
            }
            Console.WriteLine();
            var namesEndingWithM = names.Where(name => name.ToLower().EndsWith("m")).ToList();
            foreach (string n in namesEndingWithM){
                Console.WriteLine(n);
            }
            Console.WriteLine();

            Person p1 = new Person(1,"raha");
            Person p2 = new Person(2,"hadi");
            Person p3 = new Person(3,"shayan");
            Person[] people = {p1,p2,p3};

            Payment payp11 = new Payment(1,1,23);
            Payment payp12 = new Payment(1,2,324);
            Payment payp13 = new Payment(1,3,68);
            Payment payp21 = new Payment(2,1,435);
            Payment payp22 = new Payment(2,2,45);
            Payment payp23 = new Payment(2,3,23);
            Payment payp31 = new Payment(3,1,98);
            Payment payp32 = new Payment(3,2,56);
            Payment payp33 = new Payment(3,3,86);
            Payment[] payments = {payp11,payp12,payp13,payp21,payp22,payp23,payp31,payp32,payp33};

            var joined = people.GroupJoin(payments, 
                            person => person.id,
                            payment => payment.id,
                            (person, salaryGroup) => new{
                                name = person.name,
                                sumOfSalary = salaryGroup.ToArray().Sum(s => s.salary)
                            }).OrderByDescending(x => x.sumOfSalary).First();

            Console.WriteLine(joined.name);
            Console.WriteLine(joined.sumOfSalary);
        }
    }

    class Person{

        public Person(int id, string name){
            this.id = id;
            this.name = name;
        }
        public int id;
        public string name;
    }

    class Payment{
        public Payment(int id, int month, int salary){
            this.id = id;
            this.month = month;
            this.salary = salary;
        }
        public int id;
        public int month;
        public int salary;

    }
}
