import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _17_Print_Part_Of_ASCII_Table {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer startValue = Integer.parseInt(br.readLine());
        Integer endValue = Integer.parseInt(br.readLine());
        String result = "";
        for (int i = startValue; i <= endValue; i++) {
            result += (char)i + " ";
        }
        System.out.println(result);
    }
}
