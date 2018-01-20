import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _02_Add_Two_Numbers {
    public static void main(String[] args) throws IOException {
        BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
        Long numberA = Long.parseLong(bf.readLine());
        Long numberB = Long.parseLong(bf.readLine());
        Long sum = numberA + numberB;
        System.out.printf("%d + %d = %d", numberA, numberB, sum);
    }
}
