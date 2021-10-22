import java.util.Scanner;

public class MinandMax {

	 public static void main(String args[])
	    {
		    int a, b;
		    Scanner sc = new Scanner(System.in);
	        System.out.println("Enter Two Numbers :");
	        a = sc.nextInt();
	        b = sc.nextInt();
	    
	        System.out.println("****** Maximum of two numbers ******");
	        // prints the maximum of two numbers
	        System.out.println(Math.max(a, b));
	        System.out.println("****** Minimum of two numbers ******");
	        // prints the minimum of two numbers
	        System.out.println(Math.min(a, b));
	        
	    }

}
