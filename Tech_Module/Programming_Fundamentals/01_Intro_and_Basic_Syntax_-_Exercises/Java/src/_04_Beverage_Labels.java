import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;

public class _04_Beverage_Labels {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String productName = br.readLine();
        BigDecimal volume = new BigDecimal(br.readLine());
        BigDecimal multiplyIndex = volume.divide(new BigDecimal("100"));
        BigDecimal energy = new BigDecimal(br.readLine()).multiply(multiplyIndex);
        BigDecimal sugarContent = new BigDecimal(br.readLine()).multiply(multiplyIndex);
        System.out.printf("%sml %s:%n%skcal, %sg sugars",
                roundFromDecimal(volume.toString()),
                productName,
                roundFromDecimal(energy.toString()),
                roundFromDecimal(sugarContent.toString()));
    }

    private static String roundFromDecimal(String decimal) {
        Integer pointerIndex = decimal.indexOf(".");
        if (pointerIndex.equals(-1)) {
            return decimal;
        }

        String result = decimal.substring(0, pointerIndex);
        String reversed = new StringBuffer(decimal.substring(pointerIndex)).reverse().toString();
        String endResult = "";
        boolean lastFound = true;
        for (int i = 0; i < reversed.length(); i++) {
            if (reversed.charAt(i) != '0' && lastFound) {
                lastFound = false;
            }
            if (!lastFound) {
                endResult += reversed.charAt(i);
            }
        }

        endResult = new StringBuffer(endResult).reverse().toString();
        if (!endResult.equals(".")) {
            result = result + endResult;
        }
        return result;
    }
}
