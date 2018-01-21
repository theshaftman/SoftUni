import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _05_Foreign_Languages {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String country = br.readLine();
        String result;
        switch (country) {
            case "England":
            case "USA":
                result = "English";
                break;
            case "Spain":
            case "Argentina":
            case "Mexico":
                result = "Spanish";
                break;
            default:
                result = "unknown";
                break;
        }
        System.out.println(result);
    }
}
