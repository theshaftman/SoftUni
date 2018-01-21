import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _01_Passed {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Double mark = Double.parseDouble(br.readLine());
        if (mark >= 3.0) {
            System.out.println("Passed!");
        }
    }
}
