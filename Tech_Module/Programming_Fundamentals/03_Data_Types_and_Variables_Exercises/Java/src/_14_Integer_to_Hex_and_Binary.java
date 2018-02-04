import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _14_Integer_to_Hex_and_Binary {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer number = Integer.parseInt(br.readLine());
        System.out.println(Integer.toHexString(number).toUpperCase());
        System.out.println(Integer.toBinaryString(number));
    }
}
