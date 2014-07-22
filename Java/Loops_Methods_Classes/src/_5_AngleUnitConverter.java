import java.util.Scanner;


public class _5_AngleUnitConverter {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		
		for (int i = 0; i < n; i++) {
			String[] currLine = scan.nextLine().split("\\s");
			
			if (currLine[1].equals("deg")){
				System.out.printf("%.6f rad ", degToRad(Double.parseDouble(currLine[0])));
			}
			else{
				System.out.printf("%.6f deg ",radToDeg(Double.parseDouble(currLine[0])));
			}
		}

	}

	private static double radToDeg(double rad) {
		return rad*180/Math.PI;
	}

	private static double degToRad(double deg) {
		return deg*Math.PI/180.0;
	}

}
