import java.util.NoSuchElementException;
import java.util.Scanner;

public class JavaEndOfFile {
    public static void compute() {
        Scanner scanner = new Scanner(System.in);
        try {
            int lineCount = 1;
            do {
                System.out.printf("%d %s %n", lineCount++, scanner.nextLine());
            } while (scanner.hasNext());
        } catch (NoSuchElementException ex) {
            System.out.println(ex.getMessage());
        }
    }
}
