import java.util.Scanner;
public class ElseifExample {

  public static void main(String[] args) {
    int count, i;
    float totalMarks = 0, percentage;

    Scanner scanner = new Scanner(System.in);

    System.out.println("Enter Number of Subject/Subjects");
    count = scanner.nextInt();

    System.out.println("Enter Marks of " + count + " Subject/Subjects");
    for (i = 0; i < count; i++) {
      totalMarks += scanner.nextInt();
    }
    System.out.println("Total Marks : " + totalMarks);
    percentage = (totalMarks / (count * 100)) * 100;
    System.out.println("Total Percentage : " + percentage);
    if (percentage < 0 || percentage > 100) {
      System.out.println("INVALID MARKS 🤐");
    } else {
      if (percentage > 0 && percentage < 40) {
        System.out.println("FAIL 😪");
      } else if (percentage > 40 && percentage < 50) {
        System.out.println("Grade : D 😥");
      } else if (percentage > 50 && percentage < 60) {
        System.out.println("Grade : C 😑");
      } else if (percentage > 60 && percentage < 70) {
        System.out.println("Grade : B 😐");
      } else if (percentage > 70 && percentage < 80) {
        System.out.println("Grade : B+ 🙂");
      } else if (percentage > 80 && percentage < 90) {
        System.out.println("Grade : A 😊");
      } else {
        System.out.println("Grade : A+ 🤩");
      }
    }

  }

}