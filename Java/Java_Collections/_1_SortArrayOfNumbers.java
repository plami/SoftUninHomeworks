package Java_Collections;

import java.util.Arrays;
import java.util.Scanner;

public class _1_SortArrayOfNumbers {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		
		int [] numbers = new int[n];
		
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = scan.nextInt();
		}
		Arrays.sort(numbers);
		for (int j = 0; j < numbers.length; j++) {
			System.out.print(numbers[j] + " ");
		}
	}
}