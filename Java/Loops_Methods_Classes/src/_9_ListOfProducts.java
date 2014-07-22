import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintStream;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class _9_ListOfProducts {

	public static void main(String[] args) {

		String[] arrayOfProductStrings = ReadTextFile("Text.txt");
		Product[] arrayOfReadedProducts = AddListOfProducts(arrayOfProductStrings);
		WriteTextFile(SortByBigDecimalInProducts(arrayOfReadedProducts),
				"WritedProducts.txt");

	}

	public static String[] ReadTextFile(String path) {
		File file = new File(path);
		ArrayList<String> lists = new ArrayList<String>();

		try (Scanner fileReader = new Scanner(file, "UTF-8")) {
			while (fileReader.hasNext()) {
				String currentRow = fileReader.nextLine();
				lists.add(currentRow);
			}

		} catch (FileNotFoundException fnf) {
			System.err.println("File is not found");
			fnf.getStackTrace();
		} catch (IllegalArgumentException iae) {
			System.err.println("Argument is missing !");
			iae.getStackTrace();
		}

		String[] array = new String[lists.size()];
		for (int i = 0; i < lists.size(); i++) {
			array[i] = lists.get(i);
		}
		return array;
	}

	public static Product[] AddListOfProducts(String[] arrays) {

		BigDecimal currentPrice;
		boolean checkAlphaBetic = true;
		Product[] products = new Product[arrays.length];

		for (int i = 0; i < arrays.length; i++) {

			checkAlphaBetic = true;
			String currentTextString = "";
			String currentNumberString = "";
			char[] currentTextChar = arrays[i].toCharArray();

			for (int j = 0; j < currentTextChar.length; j++) {

				if (Character.isAlphabetic(currentTextChar[j])
						&& checkAlphaBetic) {
					currentTextString += currentTextChar[j];
				} else if ((Character.isDigit(currentTextChar[j]) || currentTextChar[j] == '.')) {
					checkAlphaBetic = false;
					currentNumberString += currentTextChar[j];
				} else if (currentTextChar[j] == ' ') {
					continue;
				}
			}
			products[i] = new Product(currentTextString, currentNumberString);
		}
		return products;
	}

	public static ArrayList<Product> SortByBigDecimalInProducts(Product[] prod) {

		ArrayList<Product> lists = new ArrayList<Product>(Arrays.asList(prod));
		Collections.sort(lists);
		return lists;
	}

	public static void WriteTextFile(ArrayList<Product> product, String fileName) {
		File file = new File(fileName);
		try (PrintStream fileWriter = new PrintStream(fileName, "UTF-8")) {
			for (int i = 0; i < product.size(); i++) {
				fileWriter.println(product.get(i).getNumber() + " "
						+ product.get(i).getName());
			}

		} catch (Exception e) {
			// TODO: handle exception
		}
	}
}

class Product implements Comparable<Product> {

	private String name = null;
	private BigDecimal number;

	// private File file = null;

	// constructors
	public Product(String name, String number) {
		this.name = name;
		this.number = new BigDecimal(number);
		// this.file = new File(path);
	}

	public Product() {

	}

	// --------------Name---------------------
	public String getName() {
		if (this.name == null) {
			throw new NullPointerException("Name cannot be empty");
		}
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	// -------------Number-------------------
	public BigDecimal getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = new BigDecimal(number);
	}

	@Override
	public int compareTo(Product prod) {

		if ((this.number.compareTo(prod.number)) == 1) {
			return 1;
		} else if ((this.number.compareTo(prod.number)) == -1) {
			return -1;
		} else {
			return 0;
		}
	}

}
