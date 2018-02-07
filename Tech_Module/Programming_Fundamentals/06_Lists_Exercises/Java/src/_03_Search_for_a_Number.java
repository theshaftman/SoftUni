import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class _03_Search_for_a_Number {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        List<Long> list = Arrays.stream(br.readLine().split(" "))
                .map(Long::parseLong)
                .collect(Collectors.toList());
        String[] parameters = br.readLine()
                .split(" ");
        List<Long> filteredList = list
                .subList(0, Integer.parseInt(parameters[0]));
        filteredList = skipFromList(Integer.parseInt(parameters[1]), filteredList);
        filteredList = filteredList
                .stream()
                .filter(m -> m.equals(Long.parseLong(parameters[2])))
                .collect(Collectors.toList());

        String result = filteredList.size() > 0 ? "YES!" : "NO!";
        System.out.println(result);
    }

    private static List<Long> skipFromList(int index, List<Long> inputArray) {
        List<Long> list = new ArrayList<>();
        for (int i = index; i < inputArray.size(); i++) {
            list.add(inputArray.get(i));
        }
        return list;
    }
}
