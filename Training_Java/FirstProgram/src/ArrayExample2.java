import java.util.Arrays;
import java.util.Scanner;
public class ArrayExample2 {

  public static void main(String[] args) {
    System.out.println("Enter the required size of the array :: ");
    Scanner s = new Scanner(System.in);
    int size = s.nextInt();
    int myArray[] = new int[size];
    int product = 1;
    int addition = 0;
    System.out.println("Enter the elements of the array one by one ");
    for (int i = 0; i < size; i++) {
      myArray[i] = s.nextInt();
      product = product * myArray[i];
      addition = addition + myArray[i];
    }

    System.out.println("Elements of the array are: " + Arrays.toString(myArray));
    System.out.println("Products of the elements of the array ::" + product);
    System.out.println("Sum of the elements of the array ::" + addition);

  }

}