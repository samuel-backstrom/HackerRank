import java.util.Scanner;

public class JavaStdinStdout {
    private static void compute() {
        String result;
        String[] strings = new String[3];
        Scanner scanner = new Scanner(System.in);
        scanner.useDelimiter("\n");
        for (int i = 0; i < 3; i++) {
            result = scanner.next();

            if (result.matches("(\\s*[A-Za-z]+\\s*)+"))
                strings[0] = result;
            else if (result.matches("\\d+.\\d+"))
                strings[1] = result;
            else if (result.matches("\\d+"))
                strings[2] = result;
        }

        System.out.println("String: " + strings[0]);
        System.out.println("Double: " + strings[1]);
        System.out.println("Int: " + strings[2]);
    }

    public static void run() {
        compute();
    }
}
