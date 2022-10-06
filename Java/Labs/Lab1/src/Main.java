public class Main {
    public static void main(String[] args) {
        final float a = 5;
        final float b = 1;
        final int n = 9;
        final int m = 4;
        final int C3 = 0;

        if ((a <= C3 && n >= C3)||(b<=C3&&m>=C3)) {
            System.out.println("Error! Division by 0!");
            return;
        }

        double sum = 0;
        double denominator;
        double numerator;
        for (float i = a; i <= n; i++) {
            denominator = i;
            for (float j = b; j <= m; j++) {
                numerator = (i % j);
                sum += numerator / denominator;
            }
        }
        System.out.println(sum);
    }
}
