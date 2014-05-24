package Java_Collections;

import java.util.Scanner;

public class _2_SequencesOfEqualStrings {

	public static void main(String[] args) {
	
		Scanner scan = new Scanner(System.in);
		
		String[] wordsNumbers = scan.nextLine().split(" ");
		
		System.out.print(wordsNumbers[0]);
		for (int i = 0; i < wordsNumbers.length; i++) {
			if (wordsNumbers[i].equals(wordsNumbers[i-1])) {
				System.out.print(" " + wordsNumbers[i]);
			}
			else{
				System.out.println();
				System.out.print(wordsNumbers[i]);
			}
		}
	}

}
