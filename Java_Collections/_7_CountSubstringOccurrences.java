package Java_Collections;

import java.util.Scanner;

public class _7_CountSubstringOccurrences {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		String sentence = input.nextLine().toLowerCase();
		String word = input.nextLine().toLowerCase();
		int count = 0;
		
		for (int i = 0; i <= sentence.length() - word.length(); i++) {
			if(sentence.substring(i, i + word.length()).equals(word)){
				count++;
			}
		}
		System.out.println(count);
	}

}
