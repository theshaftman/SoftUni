import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _07_Exchange_Variable_Values {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer numberA = Integer.parseInt(br.readLine());
        Integer numberB = Integer.parseInt(br.readLine());

        System.out.printf("Before:%na = %d%nb = %d%n", numberA, numberB);
        Integer numberTemp = numberA;
        numberA = numberB;
        numberB = numberTemp;
        System.out.printf("After:%na = %d%nb = %d%n", numberA, numberB);
    }
}