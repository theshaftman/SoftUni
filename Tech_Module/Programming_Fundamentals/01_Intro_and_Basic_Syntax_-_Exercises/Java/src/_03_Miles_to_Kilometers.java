import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;

public class _03_Miles_to_Kilometers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BigDecimal milesPerH = new BigDecimal(br.readLine());
        BigDecimal kmPerh = milesPerH.multiply(new BigDecimal("1.60934"));
        System.out.printf("%.2f%n", kmPerh);
    }
}
