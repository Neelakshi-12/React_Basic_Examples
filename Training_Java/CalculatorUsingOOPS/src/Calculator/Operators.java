package Calculator;
import java.util.Scanner;
public class Operators {

	  public int r_no;
	     public String name;
	     public int a,b,c;
	     int addition=0;
	     public Operators(int firstNumber , int secondNumber)
	     {
	      
	          addition = firstNumber+secondNumber;
	     }
	     public void display()
	     {
	         
	          System.out.println("-----Addition-------");
	        
	          System.out.println("Total     : "+addition);
	          System.out.println("------------------");
	     }
}
