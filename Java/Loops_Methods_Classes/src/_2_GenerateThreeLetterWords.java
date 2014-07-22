import java.util.Scanner;


public class _2_GenerateThreeLetterWords {

	public static void main(String[] args) {
	
		Scanner input = new Scanner(System.in);
		String numbers = input.nextLine();
		
		for (int i = 0; i < numbers.length(); i++) {
			for (int j = 0; j < numbers.length(); j++) {
				for (int k = 0; k < numbers.length(); k++) {
					System.out.print(numbers.charAt(i) + "" + numbers.charAt(j) + "" + numbers.charAt(k) + " ");
				}
			}
		}
	}
}
