import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;

public class _03_Employee_Data {
    public static void main(String[] args) throws IOException {
        BufferedReader bf = new BufferedReader(new InputStreamReader(System.in));
        String name = bf.readLine();
        Integer age = Integer.parseInt(bf.readLine());
        String employeeId = String.format("%08d", Long.parseLong(bf.readLine()));
        BigDecimal salary = new BigDecimal(bf.readLine());

        System.out.printf("Name: %s%nAge: %d%nEmployee ID: %s%nSalary: %.2f%n",
                name,
                age,
                employeeId,
                salary);
    }
}
