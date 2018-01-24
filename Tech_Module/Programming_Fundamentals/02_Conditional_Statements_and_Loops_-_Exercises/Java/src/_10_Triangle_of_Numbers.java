import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _10_Triangle_of_Numbers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer n = Integer.parseInt(br.readLine());
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i + 1; j++) {
                System.out.printf("%d ", i + 1);
            }
            System.out.println();
        }
    }
}
