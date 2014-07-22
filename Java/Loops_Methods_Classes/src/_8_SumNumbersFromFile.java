import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class _8_SumNumbersFromFile {

	public static void main(String[] args) {

		int sum = 0;

		File file = new File("Test.txt");

		try (Scanner fileReaderScanner = new Scanner(file, "UTF-8");) {
			while (fileReaderScanner.hasNextLine()) {
				String currentRow = fileReaderScanner.nextLine();
				sum += Integer.parseInt(currentRow);
			}

		} catch (FileNotFoundException nf) {
			System.err.printf("File %1$s is not found %n", file.getName());
			nf.printStackTrace();
			return;
		} catch (IllegalArgumentException il) {
			System.err.printf("In file %1$s values are wrong %n",
					file.getName());
			il.printStackTrace();
			return;
		}

		System.out.println(sum);
	}
}
