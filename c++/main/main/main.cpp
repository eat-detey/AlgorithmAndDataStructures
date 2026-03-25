#include <iostream>
#include <ctime>     
#include <cstdlib>   

using namespace std;

int main() 
{
    setlocale(LC_ALL, "rus");
    srand(time(NULL));

    const int S = 31; 
    int arr[S];

    cout << "Массив: " << endl;

    for (int i = 0; i < S; i++) {
        arr[i] = -15 + rand() % 31; 
        cout << arr[i] << " ";
    }
    cout << endl;

    int min = arr[0];
    int max = arr[0];

    for (int i = 1; i < S; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
        if (arr[i] > max) {
            max = arr[i];
        }
    }

    cout << "Минимальное число: " << min << endl;
    cout << "Максимальное число: " << max << endl;
    int sum = 0;        
    int count = 0;     

    for (int i = 0; i < S; i++) {
        if (arr[i] > 0) {  
            sum = sum + arr[i];
            count++;
        }
    }

    if (count > 0) {
        int a = (int)sum / count;
        cout << "Среднее арифметическое положительных чисел: " << a << endl;
    }

    cout << endl;
    return 0;
}