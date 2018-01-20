import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _01_Greeting {
    public static void main(String[] args) throws IOException {
        BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
        String line = bf.readLine();
        System.out.printf("Hello, %s!%n", line);
    }
}
