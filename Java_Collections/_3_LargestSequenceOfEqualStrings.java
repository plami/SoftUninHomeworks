package Java_Collections;

import java.util.Scanner;

public class _3_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		String[] array = scan.nextLine().split(" ");
		int count = 1;
		int counter = 1;
		int positionOfWord = 0;
		//shows the position of the last word in the largest sequence
		
		for (int i = 1; i < array.length; i++) {
			if (array[i].equals(array[i-1])) {
				count++;
			} else {
				count = 1;
			}
			if (count > counter) {
				counter = count;
				positionOfWord = i;
			}
		}
		for (int j = 0; j < count - 1; j++) {
			System.out.print(array[positionOfWord] +" ");
		}
		System.out.println(array[positionOfWord]);
	}
}
