public class Anagrams {
    public static boolean compute(String a, String b) {
        int[] alphabet = new int[26];
        String lowerCaseA = a.toLowerCase();
        String lowerCaseB = b.toLowerCase();

        for (char c : lowerCaseA.toCharArray()) {
            alphabet[(int)c - 97]++;
        }

        for (char c : lowerCaseB.toCharArray()) {
            alphabet[(int)c - 97]--;
        }

        for (int i : alphabet) {
            if (i != 0) {
                return false;
            }
        }
        return true;
    }

    public static void run() {
        compute("anagram", "marganaa");
    }
}
