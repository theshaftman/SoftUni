import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _13_Vowel_or_Digit {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String ch = br.readLine();
        if (Character.isDigit(ch.toCharArray()[0])) {
            System.out.println("digit");
        } else {
            String result;
            switch (ch.toLowerCase().toCharArray()[0]) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    result = "vowel";
                    break;
                default:
                    result = "other";
                    break;
            }
            System.out.println(result);
        }
    }
}
