import java.util.Scanner;

public class Aufgabe2{

    public static void main(String []args){
        Scanner eingabe = new Scanner(System.in);      // Eingabenscanner
        
        long lange;
        String ant;
        
        // Schreiben Sie hier Ihren Code
        do{
            long fib1 = 0;
            long fib2 = 1;
            
            //get input
            System.out.println("Wie lange soll der Fibonacci-Algorithmus laufen:");
            lange = Long.parseLong(eingabe.nextLine());
            
            //calculate and print the result
            for(int i = 0; i < lange; i++){
                
                if(i == 0){
                    System.out.print("| 0 |");
                }
                else{
                    
                    long temp = fib1 + fib2; 
                    fib1 = fib2;
                    fib2 = temp;  
                    
                    System.out.print(" "+ fib1 +" |");
                }
            }
            
            
            System.out.println("\nWollen Sie nochmal(J/N)");
            ant = eingabe.nextLine();
                
        }while(ant.equalsIgnoreCase("j"));
        
        
        
    }
}