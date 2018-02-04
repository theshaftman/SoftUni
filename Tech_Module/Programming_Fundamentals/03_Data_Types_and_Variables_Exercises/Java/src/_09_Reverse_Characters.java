import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _09_Reverse_Characters {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Character charA = br.readLine().toCharArray()[0];
        Character charB = br.readLine().toCharArray()[0];
        Character charC = br.readLine().toCharArray()[0];
        System.out.println(charC.toString() + charB.toString() + charA.toString());
    }
}