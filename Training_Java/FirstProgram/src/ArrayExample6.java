import java.util.Scanner;
import java.util.Arrays;
public class ArrayExample6 {

  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    System.out.println("Enter a string : (Use either Uppercase or Lowercase )");
    String userInput = scanner.nextLine();

    char[] charArray = userInput.toCharArray();

    Arrays.sort(charArray);
    System.out.println("Sorted string " + String.valueOf(charArray));
  }

}