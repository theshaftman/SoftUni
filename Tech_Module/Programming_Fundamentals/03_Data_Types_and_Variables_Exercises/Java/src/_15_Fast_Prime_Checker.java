import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _15_Fast_Prime_Checker {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer number = Integer.parseInt(br.readLine());
        for (Integer index = 2; index <= number; index++) {
            Boolean isPrime = true;
            for (Integer innerIndex = 2; innerIndex <= Math.sqrt(index); innerIndex++) {
                if  (index % innerIndex == 0) {
                    isPrime = false;
                    break;
                }
            }
            System.out.printf("%d -> %s%n", index, isPrime ? "True" : "False");
        }
    }
}