import java.util.Scanner;

public class StaticInitializers {
    private static int B;
    private static int H;

    static {
        try {
            B = initB();
            H = initH();
        } catch (Exception e) {
            System.out.println(e.getMessage());
            e.printStackTrace();
        }
    }

    private static int initH() throws Exception {
        Scanner scanner = new Scanner(System.in);
        int h = scanner.nextInt();
        if (h < 0) {
            throw new Exception("java.lang.Exception: Breadth and height must be positive");
        }
        return h;
    }

    private static int initB() throws Exception {
        Scanner scanner = new Scanner(System.in);
        int b = scanner.nextInt();
        if (b < 0) {
            throw new Exception("java.lang.Exception: Breadth and height must be positive");
        }
        return b;
    }
}
