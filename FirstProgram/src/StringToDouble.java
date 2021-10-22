import java.util.Scanner;

public class StringToDouble {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		double d=Double.parseDouble("23.6");  
		
		
		String firstNumber;
	 	String secondNumber;
	  Scanner in = new Scanner(System.in);
	  System.out.print("Enter First Number :: ");
	  firstNumber = in.next();
	  System.out.print("Enter Second Number :: ");
	  secondNumber = in.next();
	  
	  double i=Double.parseDouble(firstNumber);
	  double j=Double.parseDouble(secondNumber);
	  
	  double result1 = i * j;
	  double result2 = i/j;
	  System.out.println("\n****** After Multiplicating ******");
	  System.out.println("\n Result : " + result1 + " \n");
	  System.out.println("\n****** After Division ******");
	  System.out.println("\n Result : " + result2 + " \n");
	}

}
