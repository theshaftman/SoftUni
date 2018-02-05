import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _07_Max_Sequence_of_Increasing_Elements {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestLength = -1;
        int bestIndex = -1;
        for (int i = 0; i < array.length - 1; i++) {
            int checkedIndex = i;
            int checkedNextIndex = i + 1;
            int currentLength = 1;
            while (array[checkedNextIndex] > array[checkedIndex]) {
                checkedIndex += 1;
                checkedNextIndex += 1;
                currentLength += 1;
                if (checkedIndex >= array.length || checkedNextIndex >= array.length) {
                    break;
                }
            }
            if (currentLength > 1 && currentLength > bestLength) {
                bestLength = currentLength;
                bestIndex = i;
            }
        }

        for (int i = bestIndex; i < bestIndex + bestLength; i++) {
            System.out.printf("%s ", array[i]);
        }
        System.out.println();
    }
}
