import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _05_Character_Stats {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String name = br.readLine();
        Integer currentHealth = Integer.parseInt(br.readLine());
        Integer maximumHealth = Integer.parseInt(br.readLine());
        Integer currentEnergy = Integer.parseInt(br.readLine());
        Integer maximumEnergy = Integer.parseInt(br.readLine());
        System.out.printf("Name: %s%nHealth: |%s|%nEnergy: |%s|",
                name,
                new String(new char[currentHealth]).replace("\0", "|") +
                new String(new char[maximumHealth - currentHealth]).replace("\0", "."),
                new String(new char[currentEnergy]).replace("\0", "|") +
                new String(new char[maximumEnergy - currentEnergy]).replace("\0", "."));
    }
}
