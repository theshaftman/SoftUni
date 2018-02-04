import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _18_Different_Integers_Size {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String line = br.readLine();
        try {
            Long number = Long.parseLong(line);
            String result = "";
            if (number >= -128 && number <= 127) {
                result += String.format("* sbyte%n");
            }
            if (number >= 0 && number <= 255) {
                result += String.format("* byte%n");
            }
            if (number >= -32768 && number <= 32767) {
                result += String.format("* short%n");
            }
            if (number >= 0 && number <= 65535) {
                result += String.format("* ushort%n");
            }
            if (number >= -2147483648 && number <= 2147483647) {
                result += String.format("* int%n");
            }
            if (number >= 0 && number <= 4294967295l) {
                result += String.format("* uint%n");
            }
            result += String.format("* long%n");
            System.out.printf("%s can fit in:%n%s", line, result);
        } catch (Exception e) {
            System.out.println(line + " can't fit in any type");
        }
    }
}