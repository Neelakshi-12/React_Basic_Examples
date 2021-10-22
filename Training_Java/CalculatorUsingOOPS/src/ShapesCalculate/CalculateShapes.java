package ShapesCalculate;

import java.util.Scanner;

class Shapes {
	  public void area() {
	    System.out.println("The formula to find area :  ");
	  }
	public void area(int radius) {
	    System.out.println("Circle area = "+3.14*radius*radius);
	  }
	 
	public void trianglearea(int breadth, int height) {
	    System.out.println("Triangle area="+0.5*breadth*height);
	  }
	public void rectanglearea(int length, int breadth) {
	    System.out.println("Rectangle area="+length*breadth);
	  }
	 
	 
	}
public class CalculateShapes {

	  public static void main(String[] args) {
		    Shapes myShape = new Shapes();  // Create a Shapes object
		     
		    int length;
			int breadth;
		 	int height;
		 	int radius;
		 	
		  Scanner in = new Scanner(System.in);
		  System.out.print("Enter the radius :: ");
		  radius = in.nextInt();
		  System.out.print("Enter the breadth :: ");
		  breadth = in.nextInt();
		  System.out.print("Enter the length :: ");
		  length = in.nextInt();
		  System.out.print("Enter height :: ");
		  height = in.nextInt();
		    
		    myShape.area();
		    myShape.area(radius);
		    myShape.trianglearea(breadth,height);
		    myShape.rectanglearea(length,breadth);
		     
		  }
}


