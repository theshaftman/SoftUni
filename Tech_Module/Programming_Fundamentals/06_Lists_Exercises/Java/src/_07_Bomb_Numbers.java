import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

public class _07_Bomb_Numbers {

    private static int[] parameters;
    private static List<Integer> indexes;

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        List<Integer> list = Arrays.stream(br.readLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        parameters = Arrays.asList(br.readLine().split(" "))
                .stream()
                .mapToInt(Integer::parseInt)
                .toArray();
        List<Integer> indexes = new ArrayList<>();

        while (list.indexOf(parameters[0]) != -1) {
            list = updateList(list);
        }
        long sum = 0;
        for (int i = 0; i < list.size(); i++) {
            sum += list.get(i);
        }
        System.out.println(sum);
    }

    private static List<Integer> updateList(List<Integer> list) {
        indexes = new ArrayList<>();

        for (int i = 0; i < list.size(); i++) {
            if (list.get(i).equals(parameters[0])) {
                for (int j = i; j <= i + parameters[1]; j++) {
                    if (j >= list.size()) {
                        break;
                    }
                    if (indexes.indexOf(j) == -1) {
                        indexes.add(j);
                    }
                }
                for (int j = i - 1; j >= i - parameters[1]; j--) {
                    if (j < 0) {
                        break;
                    }
                    indexes.add(j);
                }

                Collections.sort(indexes);
                for (int j = indexes.size() - 1; j >= 0; j--) {
                    list.remove(Integer.parseInt(indexes.get(j).toString()));
                }
                return list;
            }
        }
        return list;
    }
}
