import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _02_Passed_or_Failed {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Double mark = Double.parseDouble(br.readLine());
        String markString = "";
        if (mark >= 3.0) {
            markString = "Passed!";
        } else {
            markString = "Failed!";
        }
        System.out.println(markString);
    }
}
