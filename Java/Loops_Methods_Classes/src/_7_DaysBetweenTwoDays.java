import java.util.Calendar;
import java.util.Scanner;


public class _7_DaysBetweenTwoDays {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] tokens1 = input.nextLine().split("-");
		String[] tokens2 = input.nextLine().split("-");
		Calendar calendar1 = Calendar.getInstance();
		Calendar calendar2 = Calendar.getInstance();
		calendar1.set(Integer.parseInt(tokens1[2]), Integer.parseInt(tokens1[1])
				, Integer.parseInt(tokens1[0]));
		calendar2.set(Integer.parseInt(tokens2[2]), Integer.parseInt(tokens2[1])
				, Integer.parseInt(tokens2[0]));
		
		long milsecs1= calendar1.getTimeInMillis();
		long milsecs2 = calendar2.getTimeInMillis();
		
		long diff = milsecs2 - milsecs1;
		long ddays = diff / (24 * 60 * 60 * 1000);
		System.out.println(ddays);
	}

}
