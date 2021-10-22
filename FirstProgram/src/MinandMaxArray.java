import java.util.Arrays;
import java.util.Scanner;
public class MinandMaxArray {

	public static void main(String[] args) {
	    int[] arr = {14, 12, 15, 13, 16};

	    int min = arr[0];
	    int max = arr[0];

	    for (int i = 1; i < arr.length; i++) {

	      min = Math.min(min, arr[i]);
	      max = Math.max(max, arr[i]);

	    }

	    System.out.println("Minimum Value: " + min);
	    System.out.println("Minimum Value: " + max);

   
    }

}
