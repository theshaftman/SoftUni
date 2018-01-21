import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.text.ParseException;

public class _03_Back_in_30_Minutes {
    public static void main(String[] args) throws IOException, ParseException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer hours = Integer.parseInt(br.readLine());
        Integer minutes = Integer.parseInt(br.readLine());
        minutes = minutes + 30;
        if (minutes >= 60) {
            hours += 1;
            minutes -= 60;
        }
        if (hours > 23) {
            hours = 0;
        }
        System.out.printf("%d:%02d%n", hours, minutes);
    }
}
