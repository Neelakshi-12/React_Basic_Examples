import java.util.Scanner;
public class SwitchCaseExample {

    public static void main(String[] args) {
        char operator;
        Double number1, number2, result;
       
        Scanner input = new Scanner(System.in);

        System.out.println("Choose an Operation To be Performed: \n 1.) Additon \n 2.) Average of Two Numbers \n 3.) Check Even or Odd \n 4.) Check Positive or Negative Numbers \n 5.) Check Prime or Not \n 6.) or Quit-Using\n");
        operator = input.next().charAt(0);

       

        switch (operator) {
            case '1':
            	 System.out.println("Enter first number");
                 number1 = input.nextDouble();

                 System.out.println("Enter second number");
                 number2 = input.nextDouble();
                result = number1 + number2;
                System.out.println("Addition : \n");
                System.out.println(number1 + " + " + number2 + " = " + result);
                break;

            case '2':
            	 System.out.println("Enter first number");
                 number1 = input.nextDouble();

                 System.out.println("Enter second number");
                 number2 = input.nextDouble();
                result = number1 + number2;
                double avg = 0.0;
                avg = result / 2;
                System.out.println(" Average of Two Numbers : \n");
                System.out.println(avg);
                break;

            case '3':
            	System.out.println("Enter any number");
            	result = input.nextDouble();
                System.out.println("Check Even or Odd : \n");
                if (result % 2 == 0)
                    System.out.println("Entered number is even");
                else
                    System.out.println("Entered number is odd");


                break;


            case '4':
            	System.out.println("Enter any number");
            	result = input.nextDouble();
                System.out.println(" Check Positive or Negative Numbers : \n");
                if (result > 0) {
                    System.out.println("The number is positive.");
                } else if (result < 0) {
                    System.out.println("The number is negative.");
                } else {
                    System.out.println("The number is zero.");
                }
                break;

            case '5':
            	System.out.println("Enter any number");
            	result = input.nextDouble();
                System.out.println(" Check Prime or Not : \n");
                boolean flag = false;
                for (int i = 2; i <= result / 2; ++i) {

                    if (result % i == 0) {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                    System.out.println(result + " is a prime number.");
                else
                    System.out.println(result + " is not a prime number.");
                break;

            case '6':
                System.out.println("Quit-Using : \n");
                System.exit(0);
                break;

            default:
                System.out.println("Perform Any Operation by Giving any number!");
                break;
        }
    }

}