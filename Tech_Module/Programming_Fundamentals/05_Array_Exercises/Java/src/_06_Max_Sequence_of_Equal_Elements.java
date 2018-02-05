import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _06_Max_Sequence_of_Equal_Elements {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestLength = -1;
        int bestIndex = -1;
        for (int i = 0; i < array.length; i++) {
            int checkedIndex = i;
            int currentLength = 0;
            while (array[checkedIndex] == array[i]) {
                checkedIndex += 1;
                currentLength += 1;
                if (checkedIndex >= array.length) {
                    break;
                }
            }
            if (currentLength > 1 && currentLength > bestLength) {
                bestLength = currentLength;
                bestIndex = i;
            }
        }

        if (bestIndex != -1) {
            for (int i = bestIndex; i < bestIndex + bestLength; i++) {
                System.out.printf("%s ", array[i]);
            }
            System.out.println();
        } else {
            System.out.println(array[0]);
        }
    }
}
