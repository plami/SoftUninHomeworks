import java.util.Scanner;

public class SumTwoNumbers {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		int firstNumber = 0, secondNumber = 0;
		int sum;
		
		System.out.println("Enter first number: ");
		firstNumber = input.nextInt();
		System.out.println("Enter second number: ");
		secondNumber = input.nextInt();
		
		sum = firstNumber + secondNumber;
		
		System.out.println("Sum of the two numbers is: " + sum);
	}

}

