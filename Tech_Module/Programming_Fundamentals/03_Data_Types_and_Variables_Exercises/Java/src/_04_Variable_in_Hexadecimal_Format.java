import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _04_Variable_in_Hexadecimal_Format {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line = br.readLine();
        Integer dec = Integer.parseInt(line.substring(2), 16);

        System.out.println(dec);
    }
}
