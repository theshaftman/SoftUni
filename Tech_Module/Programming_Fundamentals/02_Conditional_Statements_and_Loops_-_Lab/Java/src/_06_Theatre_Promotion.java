import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _06_Theatre_Promotion {
    private static String weekDay;
    private static Integer age;
    private static String errorView = "Error!";

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        weekDay = br.readLine();
        age = Integer.parseInt(br.readLine());
        String price;
        switch (weekDay) {
            case "Weekday":
                price = priceSelection(new Integer[] {12, 18, 12});
                break;
            case "Weekend":
                price = priceSelection(new Integer[] {15, 20, 15});
                break;
            case "Holiday":
                price = priceSelection(new Integer[] {5, 12, 10});
                break;
            default:
                price = errorView;
                break;
        }
        System.out.printf("%s%n", price);
    }

    private static String priceSelection(Integer[] values) {
        if (0 <= age && age <= 18) {
            return values[0].toString() + "$";
        } else if (18 < age && age <= 64) {
            return values[1].toString() + "$";
        } else if (64 < age && age <= 122) {
            return values[2].toString() + "$";
        } else {
            return errorView;
        }
    }
}
