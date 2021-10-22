import java.util.Scanner;
import java.lang.Math; 
 
public class PowerMethod {
     
public static void main(String args[]) {
         
        Double num;
        Scanner sc= new Scanner(System.in);
 
        System.out.print("Enter a number: ");
        num = sc.nextDouble();
         
        Double square = Math.pow(num, 2);
        System.out.println("Square of "+ num + " is: "+ square);
        System.out.println(" \n********* Finding Square root ******** \n");
        System.out.println(Math.sqrt(num));
        System.out.println(" \n***************** \n");
        int a, b;
        System.out.println("Enter Base value :");
        a = sc.nextInt();
        System.out.println("Enter Exponent value :");
        b = sc.nextInt();
    
        System.out.println("****** Power of numbers ******");
        System.out.println(Math.pow(a, b));
}
}