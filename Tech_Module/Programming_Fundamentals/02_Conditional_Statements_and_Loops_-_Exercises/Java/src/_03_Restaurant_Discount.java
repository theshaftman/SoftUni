import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _03_Restaurant_Discount {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer groupSize = Integer.parseInt(br.readLine());
        String groupPackage = br.readLine();
        String hall;
        Double allPrice;

        if (groupSize > 0 && groupSize <= 50) {
            hall = "Small Hall";
            allPrice = 2500.0;
        } else if (groupSize > 50 && groupSize <= 100) {
            hall = "Terrace";
            allPrice = 5000.0;
        } else if (groupSize > 100 && groupSize <= 120) {
            hall = "Great Hall";
            allPrice = 7500.0;
        } else {
            System.out.println("We do not have an appropriate hall.");
            return;
        }

        switch (groupPackage) {
            case "Normal":
                allPrice = ((allPrice + 500.0) - ((allPrice + 500.0) * 0.05)) / (double)groupSize;
                break;
            case "Gold":
                allPrice = ((allPrice + 750.0) - ((allPrice + 750.0) * 0.1)) / (double)groupSize;
                break;
            case "Platinum":
                allPrice = ((allPrice + 1000.0) - ((allPrice + 1000.0) * 0.15)) / (double)groupSize;
                break;
        }

        System.out.printf("We can offer you the %s%nThe price per person is %.2f$%n", hall, allPrice);
    }
}
