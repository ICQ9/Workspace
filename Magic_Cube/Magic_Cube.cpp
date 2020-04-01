// Magic_Cube.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
//апокалиптический магический квадрат: сумма строк, столбцов,
	//по главной и побочной диагонали - 666
	/* {3,107,5, 131,109,311,
		7,331,193,11,83,41,
		103,53,71,89,151,199,
		113,61,97, 197,167,31,
		367,13,173,59,17,37,
		73,101,127,179,139,47};*/
		//system("color 0C");



#include <iostream>
#include <iomanip>
const int n = 100, e = 100;
using namespace std;
int main()
{
	setlocale(0, "");
	int N, i, j;
	int a[n][n];
	i = j = 0;
	cout << "Magic Cube by Kovmir\n";
	cout << "Enter Array : ";
	cin >> N;
	while (i < N)
	{
		while (j < N)
		{
			a[i][j] = rand();
			cout << setw(6) << a[i][j];
			j++;
		}
		j = 0;
		cout << "\n";
		i++;
	}  //Массив a задан и показан.    
	cout << endl << endl;

	i = j = 0;
	int s[n][2], S = 0, e = 0;
	while (i < N)
	{
		while (j < N)
		{
			S = S + a[i][j];
			j++;
		}
		i++;
		j = 0;
		s[e][1] = S;
		S = 0;
		cout << setw(6) << s[e][1] << " ";
		e++;
	}
	cout << endl << endl;  //Массив s состоит из двух строк. В первую заносятся суммы элементов строк(первое число -  
 //сумма элементов первой строки и т.д.), во вторую - суммы элементов столбцов.

	S = i = j = 0;
	while (j < N)
	{
		while (i < N)
		{
			S = S + a[i][j];
			i++;
		}
		j++;
		i = 0;
		s[e][2] = S;
		S = 0;
		cout << setw(6) << s[e][2] << " ";
		e++;
	}
	cout << endl << endl;

	int f = 0;
	i = j = 0;
	while (i < (N - 1))
	{
		while (j < 3)
		{
			if (s[i][j] == s[i + 1][j + 1])  //Проверка элементов массива s на равенство. 
				f = true;
			else
				f = false;
			j++;
		}
		j = 0;
		i++;
	}

	if (f == true)
		cout << "Magic cube is True.\n";
	else
		cout << "Magic cube is False.\n";
	system("pause");
	return 0;
}
