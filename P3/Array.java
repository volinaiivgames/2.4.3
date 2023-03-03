import java.util.Scanner;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите размер массива: ");
        int size = input.nextInt(); // размер массива
        System.out.print("Введите первый член прогрессии: ");
        int firstProgression = input.nextInt(); // первый член прогрессии
        System.out.print("Введите разность прогрессии: ");
        int progressionDifference = input.nextInt(); // разность прогрессии
        input.close(); // закрытие потока ввода данных

        int[] array = new int[size]; // создаем массив

        // заполняем массив элементами прогрессии
        for (int i = 0; i < size; i++) array[i] = firstProgression + i * progressionDifference;

        // выводим массив на экран
        System.out.println(Arrays.toString(array));
    }
}
