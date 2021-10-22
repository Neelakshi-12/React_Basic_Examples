import java.util.Scanner;

public class OperatorsinJava {

    public static void main(String[] args) {
        int a, b, sum, difference, product, modulo;
        float quotient;
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Two Numbers :");
        a = sc.nextInt();
        b = sc.nextInt();
        sum = a + b;
        difference = a - b;
        product = a * b;
        quotient = (float) a / b;
        modulo = a % b;
        System.out.println("Sum : " + sum);
        System.out.println("Difference : " + difference);
        System.out.println("Product : " + product);
        System.out.println("Quotient : " + quotient);
        System.out.println("Remainder : " + modulo);

    }

}