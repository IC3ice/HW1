public class Money     {         
    public static void Change(double input){

        double Money,I,II,III,IV,V,VI,VII,VIII,IX,X,XI;
        
            I = input / 1000;
            Money = input%1000;
            Console.WriteLine("1000 Bath = {0}", Math.Floor(I));
        
            II = Money / 500;
            Money = Money%500;
            Console.WriteLine("500 Bath = {0}", Math.Floor(II));
    
            III = Money / 100;
            Money = Money%100;
            Console.WriteLine("100 Bath = {0}", Math.Floor(III));
        
            IV = Money / 50;
            Money = Money%50;
            Console.WriteLine("50 Bath = {0}", Math.Floor(IV));
        
            V = Money / 20;
            Money = Money%20;
            Console.WriteLine("20 Bath = {0}", Math.Floor(V));
        
            VI = Money / 10;
            Money = Money%10;
            Console.WriteLine("10 Bath = {0}", Math.Floor(VI));
        
            VII = Money / 5;
            Money = Money%5;
            Console.WriteLine("5 Bath = {0}", Math.Floor(VII));
      
            VIII = Money / 2;
            Money = Money%2;
            Console.WriteLine("2 Bath = {0}", Math.Floor(VIII));
       
            IX = Money / 1;
            Money = Money%1;
            Console.WriteLine("1 Bath = {0}", Math.Floor(IX));
         
            X = Money / 0.5;
            Money = Money%0.5;
            Console.WriteLine("0.50 Bath = {0}", Math.Floor(X));
  
            XI = Money / 0.25;
            Money = Money%0.25;
            Console.WriteLine("0.25 Bath = {0}", Math.Floor(XI));
    }
}