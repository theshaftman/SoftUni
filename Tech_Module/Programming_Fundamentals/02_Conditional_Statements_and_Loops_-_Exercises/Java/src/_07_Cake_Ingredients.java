import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _07_Cake_Ingredients {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line;
        Integer count = 0;
        while (!(line = br.readLine()).equals("Bake!")) {
            System.out.printf("Adding ingredient %s.%n", line);
            count += 1;
        }
        System.out.printf("Preparing cake with %d ingredients.%n", count);
    }
}
