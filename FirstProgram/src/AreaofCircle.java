import java.util.Scanner;
public class AreaofCircle {

  public static void main(String[] args) {

    //          int r;
    //	        double pi = 3.14, area;
    //	        Scanner s = new Scanner(System.in);
    //	        System.out.print("Enter radius of circle:");
    //	        r = s.nextInt();
    //	        area = pi * r * r;
    //	        System.out.println("Area of circle:"+area);

    Scanner sc = new Scanner(System.in);
    System.out.println("Enter radius of circle : ");
    double radius = sc.nextDouble();
    double area = calculateArea(radius);
    System.out.println("Area of circle : " + area);
    sc.close();
  }
  static double calculateArea(double r) {
    return (22 * r * r) / 7;
  }

}