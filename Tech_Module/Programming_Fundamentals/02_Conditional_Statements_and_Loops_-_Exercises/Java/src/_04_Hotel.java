import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _04_Hotel {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String month = br.readLine();
        Integer nightsCount = Integer.parseInt(br.readLine());

        if (month.equals("May")) {
            if (nightsCount > 7) {
                System.out.printf("Studio: %.2f lv.%n", (50.0 * (double)nightsCount) * 0.95);
            } else {
                System.out.printf("Studio: %.2f lv.%n", (50.0 * (double)nightsCount));
            }
            System.out.printf("Double: %.2f lv.%n", (65.0 * (double)nightsCount));
            System.out.printf("Suite: %.2f lv.%n", (75.0 * (double)nightsCount));
        } else if (month.equals("June")) {
            System.out.printf("Studio: %.2f lv.%n", (60.0 * (double)nightsCount));
            if (nightsCount > 14) {
                System.out.printf("Double: %.2f lv.%n", (72.0 * (double)nightsCount) * 0.90);
            } else {
                System.out.printf("Double: %.2f lv.%n", (72.0 * (double)nightsCount));
            }
            System.out.printf("Suite: %.2f lv.%n", (82.0 * (double)nightsCount));
        } else if (month.equals("July") || month.equals("August") || month.equals("December")) {
            System.out.printf("Studio: %.2f lv.%n", (68.0 * (double)nightsCount));
            System.out.printf("Double: %.2f lv.%n", (77.0 * (double)nightsCount));
            if (nightsCount > 14) {
                System.out.printf("Suite: %.2f lv.%n", (89.0 * (double)nightsCount) * 0.85);
            } else {
                System.out.printf("Suite: %.2f lv.%n", (89.0 * (double)nightsCount));
            }
        } else if (month.equals("September")) {
            if (nightsCount > 7) {
                System.out.printf("Studio: %.2f lv.%n", (60.0 * (double)(nightsCount - 1)));
            } else {
                System.out.printf("Studio: %.2f lv.%n", (60.0 * (double)nightsCount));
            }
            if (nightsCount > 14) {
                System.out.printf("Double: %.2f lv.%n", (72.0 * (double)nightsCount) * 0.9);
            } else {
                System.out.printf("Double: %.2f lv.%n", (72.0 * (double)nightsCount));
            }
            System.out.printf("Suite: %.2f lv.%n", (82.0 * (double)nightsCount));
        } else if (month.equals("October")) {
            if (nightsCount > 7) {
                System.out.printf("Studio: %.2f lv.%n", (50.0 * (double)(nightsCount - 1)) * 0.95);
            } else {
                System.out.printf("Studio: %.2f lv.%n", (50.0 * (double)nightsCount));
            }
            System.out.printf("Double: %.2f lv.%n", (65.0 * (double)nightsCount));
            System.out.printf("Suite: %.2f lv.%n", (75.0 * (double)nightsCount));
        }

    }
}
