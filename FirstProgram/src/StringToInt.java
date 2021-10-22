import java.util.Scanner;
public class StringToInt {

	public static void main(String args[]) {
		
		
		 	String firstNumber;
		 	String secondNumber;
		  Scanner in = new Scanner(System.in);
		  System.out.print("Enter First Number :: ");
		  firstNumber = in.next();
		  System.out.print("Enter Second Number :: ");
		  secondNumber = in.next();
		  
		  int i=Integer.parseInt(firstNumber);
		  int j=Integer.parseInt(secondNumber);
		  
		  int result = i + j;
		  System.out.println("\n****** After Adding ******");
		  System.out.println("\n Result : " + result + " \n");
	}


}
