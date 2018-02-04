import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _06_Strings_and_Objects {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String lineA = br.readLine();
        String lineB = br.readLine();
        String result = lineA.concat(" ".concat(lineB));
        System.out.println(result);
    }
}