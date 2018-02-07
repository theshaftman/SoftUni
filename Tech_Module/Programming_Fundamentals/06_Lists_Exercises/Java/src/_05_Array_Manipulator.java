import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class _05_Array_Manipulator {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        List<Integer> list = Arrays.stream(br.readLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        String line = "";
        while (!(line = br.readLine()).equals("print")) {
            String[] lineArray = line.split(" ");
            if (lineArray[0].equals("add")) {
                list.add(Integer.parseInt(lineArray[1]), Integer.parseInt(lineArray[2]));
            } else if (lineArray[0].equals("addMany")) {
                List<String> collectionInput = Arrays.asList(lineArray);
                collectionInput = skipFromList(2, collectionInput);
                List<Integer> collection = collectionInput
                        .stream()
                        .map(Integer::parseInt)
                        .collect(Collectors.toList());

                list.addAll(Integer.parseInt(lineArray[1]), collection);
            } else if (lineArray[0].equals("contains")) {
                System.out.println(list.indexOf(Integer.parseInt(lineArray[1])));
            } else if (lineArray[0].equals("remove")) {
                list.remove(Integer.parseInt(lineArray[1]));
            } else if (lineArray[0].equals("shift")) {
                List<Integer> rotated = new ArrayList<>();
                for (int i = 0; i < list.size(); i++) {
                    rotated.add(list.get((i + Integer.parseInt(lineArray[1])) % list.size()));
                }
                list.clear();
                list.addAll(rotated);
            } else if (lineArray[0].equals("sumPairs")) {
                List<Integer> sumList = new ArrayList<>();
                for (int i = 0; i < list.size() - 1; i += 2) {
                    sumList.add(list.get(i) + list.get(i + 1));
                }
                if (list.size() % 2 != 0) {
                    sumList.add(list.get(list.size() - 1));
                }
                list.clear();
                list.addAll(sumList);
            }
        }
        System.out.println(list);
    }

    private static List<String> skipFromList(int index, List<String> inputArray) {
        List<String> list = new ArrayList<>();
        for (int i = index; i < inputArray.size(); i++) {
            list.add(inputArray.get(i));
        }
        return list;
    }
}
