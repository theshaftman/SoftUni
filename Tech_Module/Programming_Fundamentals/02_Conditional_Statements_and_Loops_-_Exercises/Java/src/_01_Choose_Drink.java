import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _01_Choose_Drink {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String profession = br.readLine();
        String drink;
        switch (profession) {
            case "Athlete":
                drink = "Water";
                break;
            case "Businessman":
            case "Businesswoman":
                drink = "Coffee";
                break;
            case "SoftUni Student":
                drink = "Beer";
                break;
            default:
                drink = "Tea";
                break;
        }
        System.out.println(drink);
    }
}
