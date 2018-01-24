import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _06_Interval_of_Numbers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer numberA = Integer.parseInt(br.readLine());
        Integer numberB = Integer.parseInt(br.readLine());

        for (int i = Math.min(numberA, numberB); i <= Math.max(numberA, numberB); i++) {
            System.out.println(i);
        }
    }
}
