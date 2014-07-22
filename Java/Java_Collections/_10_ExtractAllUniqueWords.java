package Java_Collections;

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().toLowerCase().split("\\W+");
		
		Set<String> setWords = new TreeSet<>();
		for (String word : text) {
			setWords.add(word);
		}
		for (String word : setWords) {
			System.out.print(word + " ");
		}
	}

}
