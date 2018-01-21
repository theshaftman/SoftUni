import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _09_Multiplication_Table {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Short n = Short.parseShort(br.readLine());
        for (Short i = 1; i <= 10; i++) {
            System.out.printf("%d X %d = %d%n",
                    n,
                    i,
                    (n * i));
        }
    }
}
