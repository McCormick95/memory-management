// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x;
x = 10;
Console.WriteLine(x);
int y=x;
y=20;
Console.WriteLine(y);

Person p = new Person("Mary", "Scott");
Person q = p;

q.LName = "Smith";
Console.WriteLine(p);

Console.WriteLine(q);

string formattedPerson = Person.FormatPerson(p);
Console.WriteLine(formattedPerson);
Console.WriteLine(p);
Console.WriteLine(q);
