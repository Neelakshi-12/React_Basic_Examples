import java.util.Scanner;
public class SumOfNaturalNumbers {

  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.print("Enter any Number to find the sum of Natural Numbers:");
    int N = sc.nextInt();
    int sum = 0;

    for (int i = 0; i <= N; i++) {
      sum += i;
    }
    System.out.println("Sum of the first " + N + " natural number is: " + sum);
  }

}