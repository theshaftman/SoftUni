import java.math.BigDecimal;

public class _01_Practice_Integers {
    public static void main(String[] args) {
        Byte byteVar = -100;
        Short shortVarA = 128;
        Short shortVarB = -3540;
        Integer intVar = 64876;
        Long longVarA = 2147483648l;
        Long longVarB = -1141583228l;
        BigDecimal floatVar = new BigDecimal("-1223372036854775808");

        System.out.println(byteVar);
        System.out.println(shortVarA);
        System.out.println(shortVarB);
        System.out.println(intVar);
        System.out.println(longVarA);
        System.out.println(longVarB);
        System.out.println(floatVar);
    }
}