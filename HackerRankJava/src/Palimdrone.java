public class Palimdrone {
    public static String compute(String s) {
        java.util.Stack<Character> stack = new java.util.Stack<>();

        int dividedLength = (int) Math.round(s.length() / 2.0);
        for (int i = 0; i < dividedLength; i++) {
            stack.push(s.charAt(i));
        }

        int offset = s.length() % 2 == 0 ? dividedLength : dividedLength - 1;
        for (int i = 0; i < dividedLength; i++) {
            char c = s.charAt(i + offset);
            if (c != stack.pop()) {
                return "No";
            }
        }
        return "Yes";
    }

    public static void run() {
        compute("java");
    }
}
