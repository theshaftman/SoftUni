import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class _02_Change_List {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        List<Long> list = Arrays.stream(br.readLine().split(" "))
                .map(Long::parseLong)
                .collect(Collectors.toList());

        String line = br.readLine();
        while (!line.equals("Odd") && !line.equals("Even")) {
            String[] lineElements = line.split(" ");
            if (lineElements[0].equals("Insert")) {
                list.add(Integer.parseInt(lineElements[2]), Long.parseLong(lineElements[1]));
            } else if (lineElements[0].equals("Delete")) {
                ArrayList<Long> removeDouble = new ArrayList<>();
                removeDouble.add(Long.parseLong(lineElements[1]));
                list.removeAll(removeDouble);
            }
            line = br.readLine();
        }

        for (int i = 0; i < list.size(); i++) {
            if (line.equals("Odd") && list.get(i) % 2 != 0) {
                System.out.printf("%d ", list.get(i));
            } else if (line.equals("Even") && list.get(i) % 2 == 0) {
                System.out.printf("%d ", list.get(i));
            }
        }
        System.out.println();
    }
}
