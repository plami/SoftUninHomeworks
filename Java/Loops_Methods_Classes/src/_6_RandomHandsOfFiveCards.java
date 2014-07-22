import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;


public class _6_RandomHandsOfFiveCards {

	public static void main(String[] args) {
		
		Random randGen = new Random();
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] cards = {"2", "3", "4", "5", "6", "7"
				,"8", "9", "10", "J","Q", "K", "A"};
		char[] suits = { '♣', '♦', '♥', '♠' };
		ArrayList<String> Deck = new ArrayList<String>();
		
		for (int i = 0; i < cards.length; i++) {
			for (int j = 0; j < suits.length; j++) {
			Deck.add(cards[i] + suits[j]);
			}
		}
		for (int i = 0; i < n; i++) {
			String result = "";
			for (int j = 0; j < 5; j++) {
			result+= Deck.get(randGen.nextInt(52));
			}
			System.out.println(result);
		}
	}

}
