public class Main {
    public static void main(String[] args) {
        final double a = 3;
        final double b = 1;
        final int n = 5;
        final int m = 2;
        final int C3 = 0;

        if ((a <= C3 && n >= C3)||(b<=C3&&n>=C3)) {
            System.out.println("Error! Division by 0!");
            return;
        }

        double sum = 0;
        double denominator;
        double numerator;
        for (double i = a; i <= n; i++) {
            denominator = i;
            for (double j = b; j <= m; j++) {
                numerator = (i % j);
                sum += numerator / denominator;
            }
        }
        System.out.println(sum);
    }
}