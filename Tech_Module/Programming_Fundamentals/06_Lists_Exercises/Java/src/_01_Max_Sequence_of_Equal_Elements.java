import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class _01_Max_Sequence_of_Equal_Elements {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        double[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToDouble(Double::parseDouble)
                .toArray();

        int maxCounter = 0;
        int maxIndex = 0;
        for (int i = 0; i < array.length - 1; i++) {
            int counter = 1;
            int index = i;
            int upperIndex = i + 1;
            while (array[upperIndex] == array[index]) {
                upperIndex += 1;
                index += 1;
                counter += 1;
                if (upperIndex > array.length - 1) {
                    break;
                }
            }
            if (counter > maxCounter) {
                maxCounter = counter;
                maxIndex = i;
            }
        }
        for (int i = maxIndex; i < maxIndex + maxCounter; i++) {
            System.out.printf("%.0f ", array[i]);
        }
        System.out.println();
    }
}
