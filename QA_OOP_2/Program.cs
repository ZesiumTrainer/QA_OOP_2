using System;
namespace QA_OOP_2
{
    class Program
    {
        public class Person
        {
            // Field
            public string name;
            public string surName;
            public int yearsNum;
            // Constructor that takes no arguments.


            // Constructor that takes 3 arguments.
            public Person(string nm, string surName, int yearsNum)
            {
                //this is necesery here to distinguish input parameter from field because they share the same name
                //this is a reference to a context object
                name = nm;
                this.surName = surName;
                this.yearsNum = yearsNum;
            }

            public void SetsurName(string surName)
            {
                this.surName = surName;
            }
            // Method
            public void SetName(string newName)
            {
                name = newName;
            }
            public void SetyearsNum(int yearsNum)
            {
                this.yearsNum = yearsNum;
            }
            //virtual methods can be overriden in inheriting class.. non virtual cause compiler to give us warning
            //if we attempt to "hide" them
            public virtual string Print()
            {
                return "Osoba se zove " + name + " a preziva " + surName + "Godiste: " + godisteOsobe();
            }
            public int godisteOsobe()
            {
                return 2017 - yearsNum;
            }
        }
        //Inheritance. Employee contains all fields and methods of its parent class
        //and provides overload for Print method
        public class Employee : Person
        {

            public string radnoMesto;
            public string plata;
            public int godinaZaposlenja;

            public Employee(string nm, string surName, int yearsNum, string radnoMesto, string plata, int godinaZaposlenja) : base(nm, surName, yearsNum)
            {
                this.radnoMesto = radnoMesto;
                this.plata = plata;
                this.godinaZaposlenja = godinaZaposlenja;
            }
            
            public override  string Print()
            {
                return base.Print() + "Radno mesto je " + radnoMesto + "Iznos prihoda: " + plata + "Godina zaposlenja: " + godinaZaposlenja;
            }
        }
        //Main method is an entry point to every Console Application in .NET
        //without Main... our application would not know how to start
        static void Main(string[] args)
        {
            Employee e = new Employee("Dragan ", "Vetric ", 70, " posta ", "mala", 37);
            Console.WriteLine(e.Print());
            Console.ReadKey();
        }
    }
}
