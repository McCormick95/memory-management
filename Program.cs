// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("Hello, World!");

//int x;
//x = 10;
//Console.WriteLine(x);
//int y=x;
//y=20;
//Console.WriteLine(y);

Person p = new Person("Mary", "Scott");
Person q = p;
string formattedPerson1 = Person.FormatPerson(p);
Console.WriteLine(formattedPerson1);

q = new Person("John", "Jones");
string formattedPerson2 = Person.FormatPerson(p);
Console.WriteLine(formattedPerson2);


//int x = 4;
//int y = SquareX(x);
//int z = CubeX(x);

//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine("hello");

//static int SquareX(int x){
//    int result = x * x;
//    return result;
//}

//static int CubeX(int x){
//    int tempRes = SquareX(x);
//    int result = x * tempRes;
//    return result;
//}
