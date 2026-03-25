#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;
//функция принимает 2 указателя и не меняет значение, на которые они указывают, местами
bool SwapPtr(double* a, double* b);

//функция принимает 2 ссылки и не меняет значение, на которые они ссылаются, местами
void SwapRef(double& a, double& b);

//вывод: ссылки используем по-умолчанию. Указатели используем когда нужна гибкость(nullptr, динамические переменные, массивы)

//создание динамического массива
double* CreateArray(int N);

//вывод массива через индексы
void PrintArray(const double* const arr, int N);

//вывод массива через адресную арифметику
void PrintArray(const double* const arr, int N, int k);

//Сумма элементов масиива
void SumArray(const double* const arr, int N);

//Создание матрицы(двумерного массива)
double** CreateMatrix(int rows, int columns);

//печать матрицы
void PrintMatrix(double** m, int r, int c);

int main()
{
    setlocale(LC_ALL, "rus");

    double x = 10, y = 20;
    bool result = SwapPtr(&x, &y);
    cout << result << " " << x << " " << y << endl;

    result = SwapPtr(nullptr, &y);
    cout << result << " " << x << " " << y << endl;

    SwapRef(x, y);
    cout << " " << x << " " << y << endl;

    int N;
    cout << "Введите количество элементов в массиве: ";
    cin >> N;
    double* array = CreateArray(N);

    PrintArray(array, N);
    PrintArray(array, N, 5);

    cout << "Сумма элементов = " << SumArray(array, N) << endl;

    return 0;
}
bool SwapPtr(double* a, double* b){
    if (a == nullptr || b == nullptr) return false;

    double c = *a;
    *a = *b;
    *b = c;
    return true;
}

void SwapRef(double& a, double& b) {
    double c = a;
    a = b;
    b = c;
}

double* CreateArray(int N) {
    srand(time(NULL));
    if (N <= 0) return nullptr;

    double* arr = new double[N];
    for (int i = 0; i < N; i++) {
        arr[i] = rand() % 21 - 10; //{-10; 10}
    }
    return arr;
}
void PrintArray(const double* const arr, int N) {
 /*   cout << "Вывод через индексы: " << endl;*/
    if (arr == nullptr) return;
    for (int i = 0; i < N; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;
}

void PrintArray(const double* const arr, int N, int k) {
    if (arr == nullptr) return;
    for (int i = 0; i < N; i++) {
        cout << "Вывод через адресную арифметику: " << endl;
        cout << *(arr + i) << " ";
    }
    cout << endl;
}
void SumArray(const double* const arr, int N) {
    double sum = 0;
    for (int i = 0; i < N; i++) {
        sum += arr[i];
    }
    return sum;
}
double** CreateMatrix(int rows, int columns) {
    if (rows <= 0 || columns <= 0) return nullptr;

    double** m = new double* [rows];

    for (int i = 0; i < rows; i++) {
        m[i] = CreateArray(columns);
    }
    return m;
}
void PrintMatrix(double** m, int r, int c) {
    for (int i = 0; i < r; i++) {
        PrintArray(m[i], c);
        
    }
}