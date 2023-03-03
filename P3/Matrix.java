import java.util.Scanner;
import java.util.Arrays;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Введите количество строк: ");
        int lines = input.nextInt(); // количество строк
        System.out.print("Введите количество столбцов: ");
        int columns = input.nextInt(); // количество столбцов

        int[][] matrix = new int[lines][columns]; // создаем двумерный массив для хранения матрицы
        Random random = new Random(); // создаем объект Random для генерации случайных чисел

        // заполняем матрицу случайными числами
        for (int i = 0; i < lines; i++) { // проходим по строкам матрицы
            for (int j = 0; j < columns; j++) { // проходим по столбцам матрицы
                matrix[i][j] = random.nextInt(100); // заполняем текущий элемент матрицы случайным числом от 0 до 99
            }
        }

        // находим максимальные значения для каждого столбца
        int[] maxValues = new int[columns]; // создаем массив для хранения максимальных значений столбцов
        Arrays.fill(maxValues, Integer.MIN_VALUE); // заполняем массив максимальных значений очень маленькими значениями

        for (int j = 0; j < columns; j++) { // проходим по столбцам матрицы
            for (int i = 0; i < lines; i++) { // проходим по строкам матрицы
                if (matrix[i][j] > maxValues[j]) { // если текущий элемент больше максимального значения столбца
                    maxValues[j] = matrix[i][j]; // заменяем максимальное значение столбца
                }
            }
        }

        // находим минимальное значение в массиве максимальных значений
        int minAmongMax = Integer.MAX_VALUE; // создаем переменную для хранения минимального среди максимальных
        for (int i = 0; i < columns; i++) { // проходим по массиву максимальных значений
            if (maxValues[i] < minAmongMax) { // если текущее максимальное значение меньше переменной minAmongMax
                minAmongMax = maxValues[i]; // заменяем значение переменной minAmongMax
            }
        }

        // выводим результат на экран
        System.out.println("Матрица:");
        for (int[] row : matrix) { // проходим по строкам матрицы
            System.out.println(Arrays.toString(row)); // выводим текущую строку на экран
        }
        System.out.println("Максимальные значения для каждого столбца: " + Arrays.toString(maxValues));
        System.out.println("Минимальное среди максимальных элементов столбцов: " + minAmongMax);
    }
}
