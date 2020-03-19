public class JavaSubstrings {
    public static String compute(String s, int start, int end) {
        return s.substring(start, end);
    }

    public static void run() {
        System.out.println(compute("HelloWorld", 3, 7));
    }
}
