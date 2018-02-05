import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _08_Most_Frequent_Number {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestLength = -1;
        int bestIndex = -1;
        for (int i = 0; i < array.length; i++) {
            int currentLength = 0;
            for (int j = 0; j < array.length; j++) {
                if (array[i] == array[j]) {
                    currentLength += 1;
                }
            }

            if (currentLength > 1 && currentLength > bestLength) {
                bestLength = currentLength;
                bestIndex = i;
            }
        }

        if (bestIndex > -1) {
            System.out.println(array[bestIndex]);
        } else {
            System.out.println(array[0]);
        }
    }
}
