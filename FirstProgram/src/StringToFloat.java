import java.util.Scanner;

public class StringToFloat {

	public static void main(String[] args) {
		String firstNumber;
	 	String secondNumber;
	  Scanner in = new Scanner(System.in);
	  System.out.print("Enter First Number :: ");
	  firstNumber = in.next();
	  System.out.print("Enter Second Number :: ");
	  secondNumber = in.next();
	  
	  float i=Float.parseFloat(firstNumber);
	  float j=Float.parseFloat(secondNumber);
	  
	  float result = i - j;
	  System.out.println("\n****** After Subtracting ******");
	  System.out.println("\n Result : " + result + " \n");

	}

}
