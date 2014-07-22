import java.util.Scanner;
import java.util.Arrays;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] words = new String[n];
		
		for (int i = 0; i < n; i++) {
			words[i] = input.next();
		}
		Arrays.sort(words);
		input.nextLine();
		
		System.out.println("Output: ");
		for (int i = 0; i < n; i++) {
			System.out.println(words[i]);
		}
	}
}


