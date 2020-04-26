using System;
using System.Collections.Generic;

namespace finalexam
{
    class Program {
        static void Main(string[] args) {
            double total = 1505.20;
 
            TaxAmount tax = new TaxAmount();
            ProvinceTax provinceTax = new OntarioTax();
            tax.SetStrategy(provinceTax);
            Console.WriteLine($"OntarioTax {tax.calculate(total)}");
 
            provinceTax = new QuebecTax();
            tax.SetStrategy(provinceTax);
            Console.WriteLine($"QuebecTax {tax.calculate(total)}");
 
            Console.ReadKey();
        }
    }
 
    internal class QuebecTax : ProvinceTax {
        internal override string CalculateTax(double total) {
            return (total * 0.13).ToString();
        }
    }
 
    internal class OntarioTax : ProvinceTax {
        internal override string CalculateTax(double total) {
            return (total * 0.14975).ToString();
        }
    }
 
    internal abstract class ProvinceTax {
        internal abstract String CalculateTax(double total);
    }
    internal class TaxAmount
    {
        ProvinceTax provinceTax;
        public TaxAmount(){

        }

        //created SetStrategy to set ProvinceTax class
        internal void SetStrategy(ProvinceTax provinceTax){
            this.provinceTax=provinceTax;
        }

        //calculate method will simply call initialized provincetax object's CalculateTax method.
        internal string calculate(double total) {
            return provinceTax.CalculateTax(total).ToString();
        }
    }

    //  class Program {
    //     static void Main(string[] args) {
    //         EmployeeGroup empGrp1 = new EmployeeGroup("Finance Dept");
    //         Employee emp1 = new Employee("John Doe", 5.0);
    //         Employee emp2 = new Employee("Jane Doe", 6.0);
    //         empGrp1.AddComponent(emp1);
    //         empGrp1.AddComponent(emp2);
    //         EmployeeGroup empGrp2 = new EmployeeGroup("Marketing Dept");
    //         Employee emp3 = new Employee("Jerry Butts", 7.0);
    //         Employee emp4 = new Employee("Helen Hickory", 8.0);
    //         empGrp2.AddComponent(emp3);
    //         empGrp2.AddComponent(emp4);
    //         EmployeeGroup empGrp3 = new EmployeeGroup("All Employee");
    //         empGrp3.AddComponent(empGrp1);
    //         empGrp3.AddComponent(empGrp2);
    //         empGrp3.Display();
    //         Console.ReadKey();
    //     }
    // }
    // internal abstract class Component {
    //     internal abstract void Display();
    // }
 
    // internal class Employee : Component {
    //     private string v1;
    //     private double v2;
    //     public Employee(string v1, double v2) {
    //         this.v1 = v1;
    //         this.v2 = v2;
    //     }
    //     internal override void Display() {
    //         Console.WriteLine($"Employee Name: {v1}; Performance Rating : {v2}");
    //     }
    // }
    // internal class EmployeeGroup : Component
    // {
    //     //list to add all Employee
    //     //extending complex components that may have children.
    //     private List<Component> _children = new List<Component>();
    //     private String title;
    //     //constructor to simply display title.
    //     public EmployeeGroup(String title){
    //         this.title=title;
    //     }

    //     //Add each employee 
    //     public void AddComponent(Component component)
    //     {
    //         this._children.Add(component);
    //     }

    //     //we can add remove method to remove each employee also.

    //     internal override void Display() {
        
    //         //to display title
    //         Console.WriteLine(title);
    //         if(!title.Equals("ok"))
    //             System.Console.WriteLine("hi");
 
    //         // Recursively display child nodes
    //         foreach (Component component in _children)
    //         {
    //             component.Display();
    //         }
    //     }
    // }
    // class Program {
    //     static void Main(string[] args) {
    //         SpaceshipGenerator ssGen = new SpaceshipGenerator();
    //         Spaceship ship = ssGen.GetShip("CoreDriller");
    //         Console.WriteLine(ship.GetShipType());
    //         Console.ReadKey();
 
    //     }
    // }
 
    // internal abstract class Spaceship {
    //     public abstract string GetShipType();
    // }
 
    // internal class CoreDriller : Spaceship {
    //     public override string GetShipType() {
    //         return "CoreDriller";
    //     }
    // }
    // internal class NukeMayhem : Spaceship {
    //     public override string GetShipType() {
    //         return "NukeMayhem";
    //     }
    // }
    // internal class SwiftMaple : Spaceship {
    //     public override string GetShipType() {
    //         return "SwiftMaple";
    //     }
    // }

    // internal class SpaceshipGenerator{
    //     public SpaceshipGenerator(){

    //     }
    //     internal Spaceship GetShip(String spaceType)
    //     {
    //    //karan gajjar
    //     //depending on string of spacetype we are initializing object of different spaceship and simply returning. 
    //     Spaceship spaceShip = null;
    //     if (spaceType.Equals("CoreDriller"))
    //     {
    //         spaceShip = new CoreDriller();
    //         return spaceShip;
    //     }
    //     else if (spaceType.Equals("NukeMayhem"))
    //     {
    //         spaceShip = new NukeMayhem();
    //         return spaceShip;
    //     }
    //     else if (spaceType.Equals("NukeMayhem"))
    //     {
    //         spaceShip = new SwiftMaple();
    //         return spaceShip;
    //     }else
    //     {
    //         return spaceShip;
    //     }

    //     }
    // }
    
}
