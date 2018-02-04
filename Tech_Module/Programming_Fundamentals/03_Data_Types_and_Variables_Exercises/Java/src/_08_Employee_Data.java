import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _08_Employee_Data {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String firstName = br.readLine();
        String lastName = br.readLine();
        Integer age = Integer.parseInt(br.readLine());
        String gender = br.readLine();
        String personalId = br.readLine();
        String employeeId = br.readLine();

        System.out.printf("First name: %s%n", firstName);
        System.out.printf("Last name: %s%n", lastName);
        System.out.printf("Age: %d%n", age);
        System.out.printf("Gender: %s%n", gender);
        System.out.printf("Personal ID: %s%n", personalId);
        System.out.printf("Unique Employee number: %s%n", employeeId);
    }
}
