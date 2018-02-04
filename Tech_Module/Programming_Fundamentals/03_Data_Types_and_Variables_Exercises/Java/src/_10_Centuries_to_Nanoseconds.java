import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;

public class _10_Centuries_to_Nanoseconds {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer centuries = Integer.parseInt(br.readLine());
        Long years = Long.parseLong(centuries.toString()) * 100l;
        Long days = (Long.parseLong(years.toString()) * 3652422) / 10000;
        BigInteger hours = new BigInteger(days.toString()).multiply(new BigInteger("24"));
        BigInteger minutes = new BigInteger(hours.toString()).multiply(new BigInteger("60"));
        BigInteger seconds = new BigInteger(minutes.toString()).multiply(new BigInteger("60"));

        System.out.printf("%d centuries = %d years = %d days = %d hours" +
                        " = %d minutes = %d seconds = %d000 milliseconds = %d000000 microseconds" +
                        " = %d000000000 nanoseconds",
                centuries,
                years,
                days,
                hours,
                minutes,
                seconds,
                seconds,
                seconds,
                seconds);
    }
}
