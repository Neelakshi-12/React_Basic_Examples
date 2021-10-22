package ShapesCalculate;

import java.util.Scanner;

class CalcShapes {
	public void area() {
	    System.out.println("The formula for area of ");
	  }
	}
class Triangle extends CalcShapes {
	  public void area() {
	    System.out.println("Triangle is ½ * base * height ");
	    
	  }
	}
class Circle extends CalcShapes {
	  public void area() {
	    System.out.println("Circle is 3.14 * radius * radius ");
	  }
	}
public class CalculateShapes2 {

	  public static void main(String[] args) {
		    CalcShapes myShape = new CalcShapes();  //  CalcShapes object
		     
		
		    CalcShapes myTriangle = new Triangle();  //  Triangle object
		    CalcShapes myCircle = new Circle();  //  Circle object
		    myShape.area();
		    myTriangle.area();
		    myShape.area();
		    myCircle.area();
		     
		  }
}


