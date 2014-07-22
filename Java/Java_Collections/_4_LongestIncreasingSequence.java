package Java_Collections;

import java.util.Scanner;

public class _4_LongestIncreasingSequence {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		String[] array = scan.nextLine().split(" ");
		int[] numbers = new int[array.length];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(array[i]);
		}
		int counterTemp = 1;
		int counter = 1;
		int positionOfInt = 0;
		
		System.out.print(numbers[0]);
		for (int i = 1; i < array.length; i++) {
			if (numbers[i] > numbers[i-1]) {
				counterTemp++;
				System.out.print(" " + numbers[i]);
			} 
			else {
				counterTemp = 1;
				System.out.println();
				System.out.print(numbers[i]);
			}
			if (counterTemp > counter) {
				counter = counterTemp;
				positionOfInt = i;
			}
		}
		System.out.println();
		System.out.print("Longest: ");
		for (int j = 0; j < counter - 1; j++) {
			System.out.print(numbers[positionOfInt - (counter-1) + j] + " ");
		}
		System.out.println(numbers[positionOfInt]);
	}

}
