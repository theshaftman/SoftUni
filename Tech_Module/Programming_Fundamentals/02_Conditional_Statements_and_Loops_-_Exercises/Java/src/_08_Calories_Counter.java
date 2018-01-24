import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _08_Calories_Counter {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer n = Integer.parseInt(br.readLine());
        Integer calories = 0;
        for (int i = 0; i < n; i++) {
            String line = br.readLine();
            if (line.toLowerCase().equals("Cheese".toLowerCase())) {
                calories += 500;
            } else if (line.toLowerCase().equals("Tomato sauce".toLowerCase())) {
                calories += 150;
            } else if (line.toLowerCase().equals("Salami".toLowerCase())) {
                calories += 600;
            } else if (line.toLowerCase().equals("Pepper".toLowerCase())) {
                calories += 50;
            }
        }
        System.out.println("Total calories: " + calories);
    }
}
