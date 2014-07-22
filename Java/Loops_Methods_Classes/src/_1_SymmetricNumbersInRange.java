import java.util.Scanner;

public class _1_SymmetricNumbersInRange {
	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		String[] numbers = input.nextLine().split(" ");
		int start = Integer.parseInt(numbers[0]);
		int end = Integer.parseInt(numbers[1]);

		for (int i = start; i <= end; i++) {
			
			String number = Integer.toString(i);
			String reversed = new StringBuilder(number).reverse().toString();
			
			if(number.equals(reversed)){
				System.out.print(number + " ");
			}
		}
	}
}
