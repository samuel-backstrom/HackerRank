public class SplitRegex {
    public static void compute(String s) {
        String[] ss = s.split("[\\W]+");
        System.out.println(ss.length);
        for (String str : ss)
            System.out.println(str);
    }

    public static void run() {
        compute("           YES      leading spaces        are valid,    problemsetters are         evillllll");
    }
}
