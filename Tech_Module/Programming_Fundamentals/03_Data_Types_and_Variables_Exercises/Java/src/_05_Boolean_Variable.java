import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _05_Boolean_Variable {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line = br.readLine();
        System.out.println(line.toLowerCase().equals("true") ? "Yes" : "No");
    }
}
