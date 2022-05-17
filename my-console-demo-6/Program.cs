// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine("Hello, World!");
//var p = new Person {  Id = 4, Age = 34, Name ="Mario" };

//var x = new { Model = "Iphone 13", Price = "1000" };
//Cat a1 = new Cat();


//var emp1 = new Employee { Id = 1, FullName = "Mario Rossi", Salary = 1500.0 };
//var emp2 = new Employee { Id = 2, FullName = "Luigi Bianchi", Salary = 2500.0 };

//var x1 = emp2.CompareTo(emp1);
//Console.WriteLine(x1);

//ICollidable collidable = new Liquid();
//IUpdatable updatable = new Movable();
//IVisible visible = new Visible();

//var elementA = new ElementA(collidable, updatable, visible);
//elementA.Paint();
//elementA.Update();
//elementA.Collide();


//var x = new ArrayList();
//x.Add(1);
//x.Add("2");
//Console.WriteLine(x.Count);

//var y = new List<string>();
////y.Add("a");
////y.Add(3);

//var z = new Dictionary<int, Employee>();
//z.Add(1, new Employee { FullName = "Mario, Rossi" });

//var x = Utility.FindMinimum<int>(12, 5);
//Console.WriteLine(x);
//var z = Utility.FindMinimum<string>("Mario", "Rossi");
//Console.WriteLine(z);

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};

//bool EvenNumber(int n)
//{
//    return n % 2 == 0;
//}

//bool OddNumber(int n)
//{
//    return n % 2 != 0;
//}

//var z = numbers.FindAll(OddNumber);
//
//var z = numbers.FindAll(delegate(int n) { return n % 2 == 0; });

//var z = numbers.FindAll((int n) => { return n % 2 == 0;}); //  - >
var z = numbers.FindAll(n => n % 2 == 0);


foreach (var item in z)
{
    Console.WriteLine(item);
}


var x
    = new Person { Name = "luigi", Surname = "bianchi" };

var fullName = x.FullName("$$$");
Console.WriteLine(fullName);



var z1 = numbers.Where(x => x % 2 == 0);
var z2 = numbers.Select(x => x * 20);
foreach (var item in z2)
{
    Console.WriteLine(item);
}

var z3 = numbers.Select(x => new Employee { Id = x });
var z4 = new List<Employee>().OrderBy(emp => emp.Salary);
