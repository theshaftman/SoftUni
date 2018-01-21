import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _11_Odd_Number {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer number;
        while ((number = Integer.parseInt(br.readLine())) % 2 == 0) {
            System.out.println("Please write an odd number.");
        }
        System.out.printf("The number is: %d%n", Math.abs(number));
    }
}
