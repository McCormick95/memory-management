
public class Person{
    public string FName{get; set;}
    public string LName{get; set;}
    public Person(string fName, string lName){
        FName = fName;
        LName = lName;
    }
    public override string ToString(){
        return FName + " " + LName;
    }
    public static string FormatPerson(Person p){
        string result;
        result = p.LName+ ", " + p.FName;
        p.LName = "Whitaker";
        return result;
    }
}


