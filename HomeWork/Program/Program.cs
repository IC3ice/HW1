using System;

public class Program {

    public static Store CreateStore(string Name,double Number,string Owner,double Value) {
    return new Store (Name,Number,Owner,Value);
    }
    public static void Main(string[] args){
        string Name = recname();
        double Number = recnumber();
        string Owner = recowner();
        double Value = recValue();
        Store zzz = new Store(Name,Number,Owner,Value);
        PrdoubleStoreInformation(zzz);
        Console.WriteLine("Please input money");
        double input=double.Parse(Console.ReadLine());
        MAM.Change(input);
    }
    public static string recname(){
        Console.WriteLine("Please input Name:");
        string Name = Console.ReadLine();
        return Name;
    }
    public static double recnumber(){
        Console.WriteLine("Please input Number:");
        double Number = double.Parse(Console.ReadLine());
        return Number;
    }
    public static string recowner(){
        Console.WriteLine("Please input Owner Name:");
        string Owner = Console.ReadLine();
        return Owner;
    }
    public static double recValue(){
        Console.WriteLine("Please input Registered Value:");
        double Value = double.Parse(Console.ReadLine());
        return Value;
    }
    static void PrdoubleStoreInformation(Store Store) {
        Console.WriteLine("**************************");
        Console.WriteLine("Name: {0}", Store.Name);
        Console.WriteLine("Number: {0}", Store.Number);
        Console.WriteLine("Owner: {0}", Store.Owner);
        Console.WriteLine("Register Valure: {0}", Store.Value);
        Console.WriteLine("**************************");
        
    }
}