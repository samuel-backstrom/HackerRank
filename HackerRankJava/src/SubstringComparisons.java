import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class SubstringComparisons {
    public static List<String> compute(String s, int k) {
        List<String> subStrings = new ArrayList<>();
        int i = 0;
        while ((i + k) <= s.length()) {
            subStrings.add(s.substring(i, (i + k)));
            i += 1;
        }

        subStrings.sort(String::compareTo);
        return subStrings;
    }

    public static void run() {
        System.out.println(Arrays.toString(compute("welcometojava", 3).toArray()));
    }
}
