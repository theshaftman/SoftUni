import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _10_Multiplication_Table_2 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Short n = Short.parseShort(br.readLine());
        Short startIndex = Short.parseShort(br.readLine());

        if (startIndex >= 0 && startIndex <= 10) {
            for (Short i = startIndex; i <= 10; i++) {
                System.out.printf("%d X %d = %d%n",
                        n,
                        i,
                        (n * i));
            }
        } else {
            System.out.printf("%d X %d = %d%n",
                    n,
                    startIndex,
                    (n * startIndex));
        }
    }
}
