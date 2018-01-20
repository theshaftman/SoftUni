import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _02_Rectangle_Area {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Double width = Double.parseDouble(br.readLine());
        Double height = Double.parseDouble(br.readLine());
        Double rectangleArea = width * height;
        System.out.printf("%.2f%n", rectangleArea);
    }
}
