import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _16_Comparing_floats {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String numberA = br.readLine().replace('-', ' ').trim();
        String numberB = br.readLine().replace('-', ' ').trim();

        String parsedA = format(numberA);
        String parsedB = format(numberB);
        System.out.println(parsedA.equals(parsedB) ? "True" : "False");
    }

    private static String format(String value) {
        Integer index = value.lastIndexOf(".");
        String result = value.substring(0, index);
        for (int i = index; i < value.length(); i++) {
            if (i > 7) {
                break;
            }
            result += value.toCharArray()[i];
        }
        return result;
    }
}
