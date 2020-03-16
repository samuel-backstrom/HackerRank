import java.util.Calendar;
import java.util.Locale;

import static java.util.Calendar.LONG;

public class JavaCalender {
    private final static int MONTH_OFFSET = 1;
    public static String findDay(int day, int month, int year) {
        Calendar c = Calendar.getInstance();
        month = month - MONTH_OFFSET;
        c.set(year, month, day);
        return c.getDisplayName(Calendar.DAY_OF_WEEK, LONG, Locale.ENGLISH);
    }

    public static void compute() {
        System.out.println(findDay(15, 3, 2020));
    }
}
