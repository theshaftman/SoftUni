import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;

public class _06_Sum_Reversed_Numbers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        List<String> list = Arrays.asList(br.readLine().split(" "));

        long sum = 0;
        for (int i = 0; i < list.size(); i++) {
            sum += Long.parseLong(reverse(list.get(i)));
        }
        System.out.println(sum);
    }

    private static String reverse(String string) {
        String line = "";
        for (int i = string.length() - 1; i >= 0; i--) {
            line += string.charAt(i);
        }
        return line;
    }
}
