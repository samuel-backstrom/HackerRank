import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ValidIPAddressRegex {
    public static boolean compute(String ipAddress) {
        String regex = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        Pattern p = Pattern.compile(regex);
        Matcher m = p.matcher(ipAddress);
        return m.matches();
    }

    public static void run() {
        System.out.println(compute("123.123.123.123"));
    }
}
