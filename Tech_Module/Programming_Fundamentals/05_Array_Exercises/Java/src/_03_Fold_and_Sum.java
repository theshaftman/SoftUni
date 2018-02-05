import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _03_Fold_and_Sum {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();

        // Fill second row array
        int[] secondRow = new int[array.length / 2];
        for (int i = 0; i < secondRow.length; i++) {
            secondRow[i] = array[i + (array.length / 4)];
        }

        // Fill first row array
        int[] firstRow = new int[array.length / 2];
        int index = 0;
        for (int i = array.length / 4 - 1; i >= 0; i--, index += 1) {
            firstRow[index] = array[i];
        }
        for (int i = 0, j = array.length - 1; i < array.length / 4; i++, j--, index++) {
            firstRow[index] = array[j];
        }

        // Fill sum array
        int[] sumArray = new int[firstRow.length];
        for (int i = 0; i < sumArray.length; i++) {
            sumArray[i] = firstRow[i] + secondRow[i];
        }

        for (int i = 0; i < sumArray.length; i++) {
            System.out.printf("%s ", sumArray[i]);
        }
        System.out.println();
    }
}
