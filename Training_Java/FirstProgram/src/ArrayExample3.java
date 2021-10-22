import java.util.Arrays;
import java.util.Scanner;
public class ArrayExample3 {
  public static void main(String[] args) {
    System.out.println("Please enter the length of array?");
    Scanner scnr = new Scanner(System.in);
    int length = scnr.nextInt();
    int[] input1 = new int[length];
    System.out.println("Please enter elements of array");
    for (int i = 0; i < length; i++) {
      input1[i] = scnr.nextInt();
    }
    int[] input2 = new int[length];
    System.out.println("Please enter elements of array");
    for (int i = 0; i < length; i++) {
      input2[i] = scnr.nextInt();
    }
    int total1 = sumOfElements(input1);
    int total2 = sumOfElements(input2);
    System.out.println("Sum of all elements of First array is " + total1);
    System.out.println("Sum of all elements of Second array is " + total2);
    int result = total1 + total2;
    System.out.println("Sum of two arrays is " + result);
    scnr.close();
  }
  public static int sumOfElements(int[] array) {
    int sum = 0;
    for (int i: array) {
      sum = sum + i;
    }
    return sum;
  }
}