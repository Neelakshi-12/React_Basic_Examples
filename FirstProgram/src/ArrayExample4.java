import java.util.Arrays;
import java.util.Scanner;
public class ArrayExample4 {
  public static void main(String[] args) {
    System.out.println("Please enter the length of array :: ");
    Scanner scnr = new Scanner(System.in);
    int length = scnr.nextInt();
    int[] input1 = new int[length];
    System.out.println("Please enter elements of First array :: ");
    for (int i = 0; i < length; i++) {
      input1[i] = scnr.nextInt();
    }
    int[] input2 = new int[length];
    System.out.println("Please enter elements of Second array :: ");
    for (int i = 0; i < length; i++) {
      input2[i] = scnr.nextInt();
    }
    System.out.println("Elements of the First array are: " + Arrays.toString(input1));
    System.out.println("Elements of the Second array are: " + Arrays.toString(input2));

    int totalLength = input1.length + input2.length;

    int[] result = new int[totalLength];
    int sumOfTotalLength = 0;
    for (int i = 0; i < input1.length; i++) {
      int element = input1[i];
      result[sumOfTotalLength] = element;
      sumOfTotalLength++;
    }

    for (int i = 0; i < input2.length; i++) {
      int element = input2[i];
      result[sumOfTotalLength] = element;
      sumOfTotalLength++;
    }

    System.out.println(Arrays.toString(result));
    Arrays.sort(result);

    System.out.println("Elements of array sorted : ");

    for (int i = 0; i < result.length; i++) {
      System.out.println(result[i]); // not able to use arrays.tostring
    }
    System.out.println("Elements of Sorted array are: " + Arrays.toString(result)); //done
  }

}