public class JavaStrings {
    public static String compute(String A, String B) {
        int lengthSum = A.length() + B.length();

        String response = A.compareTo(B) > 0 ? "Yes" : "No";

        char firstCharInA = A.charAt(0);
        String capitalizedA = A.replaceFirst(String.valueOf(firstCharInA),
                String.valueOf(Character.toUpperCase(firstCharInA)));
        char firstCharInB = B.charAt(0);
        String capitalizedB = B.replaceFirst(String.valueOf(firstCharInB),
                String.valueOf(Character.toUpperCase(firstCharInB)));

        return String.format("%d%n%s%n%s", lengthSum, response, capitalizedA.concat(" ").concat(capitalizedB));
    }

    public static void run() {
        System.out.println(compute("hello", "world"));
    }
}
