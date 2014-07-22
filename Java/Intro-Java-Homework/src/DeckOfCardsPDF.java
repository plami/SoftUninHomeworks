import java.io.FileOutputStream;
import java.io.IOException;

import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Font.FontFamily;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;


public class DeckOfCardsPDF {

	 public static final String RESULT = "deckOfCards.pdf";
	    
		public static void main(String[] args) throws DocumentException,
		IOException{
			new DeckOfCardsPDF().createPdf(RESULT);
		}
	    public static final Font NORMAL = new Font(FontFamily.SYMBOL, 13);
	    public static final Font RED = new Font(FontFamily.SYMBOL, 13);
		
	    public void createPdf(String filename) throws DocumentException,
	    IOException {
				
	        Document document = new Document();
	        PdfWriter.getInstance(document, new FileOutputStream("MyFirstFile.pdf"));                      
	        document.open();
	        

	        document.add(createTable());
	        document.close();
	    }
	        
	    public PdfPTable createTable() {
	    	 
	        String card = "";
	        PdfPTable cards = new PdfPTable(8);

	        cards.setWidthPercentage(50);
	        cards.getDefaultCell().setFixedHeight(55);
	        cards.getDefaultCell().setPadding(2);
	        
			
			for (int i = 0; i < 14; i++) {
				
				switch(i){
				
				case 1 : card = "A"; break;
				case 2 : card = "2" ; break;
				case 3 : card = "3"; break;
				case 4 : card = "4"; break;
				case 5 : card = "5"; break;
				case 6 : card = "6"; break;
				case 7 : card = "7"; break;
				case 8 : card = "8"; break;
				case 9 : card = "9"; break;
				case 10 : card = "10"; break;
				case 11 : card = "J"; break;
				case 12 : card = "Q"; break;
				case 13 : card = "K"; break;
				}
				
	            PdfPCell cell = new PdfPCell();
	            cell.setBorder(PdfPCell.NO_BORDER);

	            char p = 167;
	            cards.addCell((new Paragraph("\n "+ card + p, NORMAL)));
	            cards.addCell(cell);
	          
	            char q = 170;
	            cards.addCell(new Paragraph("\n " + card + q, NORMAL));
	            cards.addCell(cell);

	            for (char j = 168; j < 170; j++) {
	                    RED.setColor(BaseColor.RED);
	                    cards.addCell(new Paragraph("\n " + card + j, RED));
	                    cards.addCell(cell);
	            }
	    }
	    return cards;
		}
	}
