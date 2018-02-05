import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _05_Compare_Char_Arrays {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String[] arrayA = br.readLine().split(" ");
        String[] arrayB = br.readLine().split(" ");
        int equallityIndex = arraysEqualIndex(convertToCharArray(arrayA), convertToCharArray(arrayB));

        if (equallityIndex != -1) {
            printArray(arrayA);
            printArray(arrayB);
        } else {
            printArray(arrayB);
            printArray(arrayA);
        }
    }

    private static char[] convertToCharArray(String[] array) {
        char[] charArray = new char[array.length];
        for (int i = 0; i < array.length; i++) {
            charArray[i] = array[i].charAt(0);
        }
        return charArray;
    }

    private static int arraysEqualIndex(char[] arrayA, char[] arrayB) {
        int minLength = Math.min(arrayA.length, arrayB.length);
        for (int i = 0; i < minLength; i++) {
            if ((int)arrayA[i] > (int)arrayB[i]) {
                return -1;
            } else if ((int)arrayA[i] < (int)arrayB[i]) {
                return 1;
            }
        }
        if (arrayA.length > arrayB.length) {
            return -1;
        } else if (arrayB.length > arrayA.length) {
            return 1;
        }
        return 0;
    }

    private static void printArray(String[] array) {
        for (int i = 0; i < array.length; i++) {
            System.out.printf("%s", array[i]);
        }
        System.out.println();
    }
}