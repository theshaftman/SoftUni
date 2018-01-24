import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _02_Choose_Drink_2 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String profession = br.readLine();
        Integer quantity = Integer.parseInt(br.readLine());
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
        Double totalPrice = 0.0;
        switch (drink) {
            case "Water":
                totalPrice = (double)quantity * 0.7;
                break;
            case "Coffee":
                totalPrice = (double)quantity * 1.0;
                break;
            case "Beer":
                totalPrice = (double)quantity * 1.7;
                break;
            case "Tea":
                totalPrice = (double)quantity * 1.2;
                break;
        }
        System.out.printf("The %s has to pay %.2f.%n", profession, totalPrice);
    }
}
