import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.List;

public class _02_Rotate_and_Sum {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int[] array = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();
        int turns = Integer.parseInt(br.readLine());
        int[] sumArray = new int[array.length];

        for (int i = 0; i < turns; i++) {
            int[] rotated = new int[array.length];
            rotated[0] = array[array.length - 1];
            for (int j = 1; j < array.length; j++) {
                rotated[j] = array[j - 1];
            }
            for (int j = 0; j < sumArray.length; j++) {
                sumArray[j] += rotated[j];
            }
            array = rotated;
        }
        for (int i = 0; i < sumArray.length; i++) {
            System.out.printf("%s ", sumArray[i]);
        }
        System.out.println();
    }
}
