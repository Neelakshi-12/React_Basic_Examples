package AreaCalculator;
import java.util.Scanner;
public class ToCalculate {

	public static void main(String[] args) {
		Scanner in=new Scanner(System.in);
		float res;
		Square s1=new Square();
		Rectangle r1=new Rectangle();
		SquarePerimeter s2=new SquarePerimeter();
		RectanglePerimeter r2=new RectanglePerimeter();
		System.out.println("Enter length for square to calculate area");
		res=s1.area(in.nextInt());
		System.out.println(res);
		System.out.println("Enter length for square to calculate perimeter");
		res=s2.perimeter(in.nextInt());
		System.out.println(res);
		System.out.println("Enter length and breadth for rectangle to calculate area");
		res=r1.area(in.nextInt(),in.nextInt());
		System.out.println(res);
		System.out.println("Enter length and breadth  for rectangle to calculate perimeter");
		res=r2.perimeter(in.nextInt(),in.nextInt());
		System.out.println(res);

	}

}
