import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _05_Word_in_Plural {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String word = br.readLine();

        if (word.lastIndexOf("y") == word.length() - 1) {
            word = word.substring(0, word.length() - 1) + "ies";
        } else if ((word.lastIndexOf("o") == word.length() - 1) ||
                (word.lastIndexOf("s") == word.length() - 1) ||
                (word.lastIndexOf("x") == word.length() - 1) ||
                (word.lastIndexOf("z") == word.length() - 1) ||
                (word.lastIndexOf("ch") == word.length() - 1 - 1) ||
                (word.lastIndexOf("sh") == word.length() - 1 - 1)) {
            word += "es";
        } else {
            word += "s";
        }
        System.out.println(word);
    }
}
