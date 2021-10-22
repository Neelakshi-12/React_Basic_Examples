package MainCalculator;
import java.util.Scanner;
public class ToCalculate {

	public static void main(String[] args) {
		System.out.println("Enter two values for addition");
		Scanner in=new Scanner(System.in);
		Addition a1=new Addition();
		int res=a1.display(in.nextInt(),in.nextInt());
		System.out.println("The sum is: "+ res + "");
		
		System.out.println("Enter two values for Subtraction");
		Subtraction s1=new Subtraction();
	    res=s1.display(in.nextInt(),in.nextInt());
	    System.out.println("The differences are: "+res+"  ");
		
		System.out.println("Enter two values for Multiplication");
		Multiplication m1=new Multiplication();
		res=m1.display(in.nextInt(),in.nextInt());
		System.out.println("The products are: "+res+" ");

	}

}
