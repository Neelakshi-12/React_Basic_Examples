package Calculator;
import java.util.*;
import java.lang.*;
import java.io.*;
public class MainCalculator {

	public static void main(String[] args) {
		
         int firstNumber;
         int secondNumber;
         Scanner sc = new Scanner(System.in);
         System.out.print("Enter 1 num:= ");
         firstNumber = sc.nextInt();
         System.out.print("Enter 2 num:= ");
         secondNumber = sc.nextInt();
       
         Operators s = new Operators( firstNumber,secondNumber);
         s.display();

	}
}