import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _08_Sum_of_Odd_Numbers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer n = Integer.parseInt(br.readLine());
        Long sum = 0l;
        for (int i = 1; i < 100; i++) {
            if (i % 2 != 0 && n > 0) {
                sum += i;
                System.out.println(i);
                n -= 1;
            }
            if (n == 0) {
                break;
            }
        }
        System.out.printf("Sum: %d%n", sum);
    }
}
