// See https://aka.ms/new-console-template for more information



// using SimpleCalculator1.Classes;

// Person person = new Person();

// person.b = 12;
// person.a = 20;
// person.belgi = "-";
// person.Amallar();






hi:

System.Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter b number: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Amalni kiriting: ");
string belgi = Console.ReadLine();



if(belgi == "+"){
    System.Console.WriteLine($"{a} + {b} = {a + b}");
}
else if(belgi == "-"){
    System.Console.WriteLine($"{a} - {b} = {a - b}");
}
else if(belgi == "*"){
    System.Console.WriteLine($"{a} * {b} = {a * b}");
}
else if(belgi == "/"){
    System.Console.WriteLine($"{a} / {b} = {a / b}");
}
else{
    System.Console.WriteLine("Not found!");
}   

System.Console.Write("Shall we continue?: ");
string s = Console.ReadLine();
if(s == "yes"){
    goto hi;
}
else{
    System.Console.WriteLine("Ok bro ;)");
}


