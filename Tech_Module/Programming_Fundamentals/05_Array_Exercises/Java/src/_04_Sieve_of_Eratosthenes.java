import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _04_Sieve_of_Eratosthenes {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(br.readLine());
        boolean[] array = new boolean[n + 1];
        for (int i = 2; i <= n; i++) {
            array[i] = true;
        }

        for (int i = 0; i < array.length; i++) {
            if (array[i]) {
                for (int p = 2; (p * i) <= n; p++) {
                    array[p * i] = false;
                }
            }
        }
        for (int i = 2; i < array.length; i++) {
            if (array[i]) {
                System.out.printf("%s ", i);
            }
        }
        System.out.println();
    }
}