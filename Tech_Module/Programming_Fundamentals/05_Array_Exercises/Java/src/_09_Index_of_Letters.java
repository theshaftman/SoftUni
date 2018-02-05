import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _09_Index_of_Letters {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        char[] array = br.readLine().toCharArray();
        for (int i = 0; i < array.length; i++) {
            System.out.printf("%s -> %d%n", array[i], array[i] - 97);
        }
    }
}