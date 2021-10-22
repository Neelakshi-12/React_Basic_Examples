import java.util.Arrays;
import java.util.Scanner;
public class ArrayExample5 {

  public static void main(String args[]) {
    Scanner sc = new Scanner(System.in);

    System.out.print("Enter the Array length: ");

    int length = sc.nextInt();

    char arr[] = new char[length];
    System.out.println("Enter any " + length + " Characters");
    for (int i = 0; i < length; i++) {
      arr[i] = sc.next().charAt(0);

    }
    System.out.println("\nEntered characters are:");
    for (int j = 0; j < length; j++) {
      System.out.println(arr[j]);
    }
    System.out.println("Elements of Character Array : " + Arrays.toString(arr));
    Arrays.sort(arr);
    System.out.println("Sorted string " + String.valueOf(arr));
    System.out.println("Sorted Character Array : " + Arrays.toString(arr));
  }

}