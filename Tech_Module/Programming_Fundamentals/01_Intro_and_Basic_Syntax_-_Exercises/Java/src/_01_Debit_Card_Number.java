import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.stream.Collectors;

public class _01_Debit_Card_Number {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String[] array = new String[4];
        for (int i = 0; i < array.length; i++) {
            array[i] = String.format("%04d", Long.parseLong(br.readLine()));
        }
        System.out.println(Arrays.stream(array)
                .map(String::valueOf)
                .collect(Collectors.joining(" ")));
    }
}
