import java.util.Scanner;
public class ArrayExample1 {
  private static Scanner sc;

  static int arr[] = {
    1,
    2,
    3,
    4,
    5,
    6
  };
  static int multiply() {
    int product = 1;
    for (int i = 0; i < arr.length; i++)
      product = product * arr[i];
    return product;
  }

  static int addition() {
    int addition = 1;
    for (int i = 0; i < arr.length; i++)
      addition = addition + arr[i];
    return addition;
  }
  public static void main(String[] args) {
    System.out.println(multiply());
    System.out.println(addition());
  }

}