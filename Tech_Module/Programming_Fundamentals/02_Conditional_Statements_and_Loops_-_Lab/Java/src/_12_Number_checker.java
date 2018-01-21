import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _12_Number_checker {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line = br.readLine();
        try {
            Double number = Double.parseDouble(line);
            System.out.println("It is a number.");
        } catch (Exception e) {
            System.out.println("Invalid input!");
        }
    }
}
