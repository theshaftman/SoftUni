import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _10_Pairs_by_Difference {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();
        int sum = Integer.parseInt(br.readLine());

        int totalPairs = 0;
        for (int i = 0; i < array.length; i++) {
            for (int j = i; j < array.length; j++) {
                if ((Math.max(array[i], array[j]) - Math.min(array[i], array[j])) == sum) {
                    totalPairs += 1;
                }
            }
        }
        System.out.println(totalPairs);
    }
}
