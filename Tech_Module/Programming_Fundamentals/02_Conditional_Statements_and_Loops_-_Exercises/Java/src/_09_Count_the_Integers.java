import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _09_Count_the_Integers {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line;
        int count = 0;
        while (true) {
            line = br.readLine();
            try {
                Long number = Long.parseLong(line);
                count += 1;
            } catch (Exception e) {
                break;
            }
        }
        System.out.println(count);
    }
}
