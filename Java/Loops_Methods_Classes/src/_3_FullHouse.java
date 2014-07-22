import java.util.ArrayList;


public class _3_FullHouse {
	public static void main(String[] args){
		
		String[] cards = { "2", "3", "4", "5", "6", "7"
				,"8", "9", "10", "J","Q", "K", "A",};
		char[] suits = { '♣', '♦', '♥', '♠' };
		
		int count = 0;
		String[] results = new String[5];
		
		for (int i = 0; i < cards.length; i++) {
			for (int j = 0; j < results.length; j++) {
				if(j == i){continue;}
				for (int k = 0; k < suits.length; k++) {
					for (int m = k+1; m < suits.length; m++) {
						for (int l = m+1; l < suits.length; l++) {
							for (int p = 0; p < suits.length; p++) {
								for (int q = p + 1; q < suits.length; q++) {
									results [4] = cards[i] + suits[k];
									results [3] = cards[i] + suits[m];
									results [2] = cards[i] + suits[l];
									results [1] = cards[j] + suits[p];
									results [0] = cards[j] + suits[q];
									count++;
									System.out.println("(" +results[4] + results[3]
											+ results[2] + results[1] + results[0] +")");
								}
							}
						}
					}
				}
					
				}
				
			}
		System.out.println();
		System.out.println(count);
		}
		
	}


