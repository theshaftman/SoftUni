import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Collections;

public class _01_Largest_Common_End {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String[] firstInputArray = br.readLine().split(" ");
        String[] secondInputArray = br.readLine().split(" ");

        int commonEnd = 0;
        int maxCommonEnd = 0;
        int minLength = Math.min(firstInputArray.length, secondInputArray.length);

        for (int i = 0; i < minLength; i++) {
            if (firstInputArray[i].equals(secondInputArray[i])) {
                commonEnd += 1;
                continue;
            }
            break;
        }
        maxCommonEnd = commonEnd;
        commonEnd = 0;
        Collections.reverse(Arrays.asList(firstInputArray));
        Collections.reverse(Arrays.asList(secondInputArray));
        for (int i = 0; i < minLength; i++) {
            if (firstInputArray[i].equals(secondInputArray[i])) {
                commonEnd += 1;
                continue;
            }
            break;
        }

        maxCommonEnd = Math.max(maxCommonEnd, commonEnd);
        System.out.println(maxCommonEnd);
    }
}
