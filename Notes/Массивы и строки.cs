
Массив представляет собой совокупность переменных одного типа с общим для обращения к ним именем.
н-р, в массиве можно хранить максимальные суточные t C, название книг из библиотеки и т.д.

Преимущество - организация данных.
Они реализованые в виде объектов. Позвонялют организовать данные так, чтобы легко отсортировать их.

Одномерные массивы
Массив - совокупность переменных одного типа, объединенных под одним именем.

string void Main (string [] args)
string [] array = new string [5];
array [0] = "Gurkiran";
[0] - мндекс элемента

Одномерный массив представляет собой список связанных переменных (н-р, можно хранить учетные номера активных пользователей сети, текущие средниек уровни достижений бейсбольной команды)

Массивы в С# реализованы в виде объектов.

тип [] имя_массива = new тип [размер];
тип - обьявляет конкретный тип элемента массива.
[] - указывают, что объявляется одномерный массив.
int [] sample = new int [10];
int [] sample;
sample = new int [10];
доступ к отдельному элементу массива по индексу, индекс обозначает положение элемента в массиве.


Инициализация:
тип [] имя_массива = {vall1, vall2, vall3...}
1. int [] nums = new int [] {99,10,100,18,78,23};
2. int [] nums;
nums = new int [] {99,10,100,18,78,23,63}
3.int [] nums = new int [10] {99,10,100...}

Двумерный массив

int [,] table = new int [10,20];
table [3,5] = 10;