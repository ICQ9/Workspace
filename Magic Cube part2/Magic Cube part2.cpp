// Magic Cube part2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#define N 6
using namespace std;

int main()
{
	system("color 0C");
	int i, j;
	//апокалиптический магический квадрат: сумма строк, столбцов,
	//по главной и побочной диагонали - 666
	int ApMS[N][N] =
	{ 3, 107,     5, 131,      109,   311,
	7,  331,    193,    11,     83, 41,
	103,    53, 71, 89, 151,    199,
	113,     61,    97, 197,    167,    31,
	367,     13,    173,    59,     17, 37,
	73,    101, 127,    179,    139,    47 };

	//суммы строк
	int raws[N] = { 0,0,0,0,0,0 };
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < N; j++)
			raws[i] += ApMS[i][j];
		cout << "Raw" << i << ": " << raws[i] << endl;
	}
	//суммы столбцов
	int cols[N] = { 0,0,0,0,0,0 };
	for (j = 0; j < N; j++)
	{
		for (i = 0; i < N; i++)
			cols[j] += ApMS[i][j];
		cout << "Column" << j << ": " << cols[j] << endl;
	}
	//сумма главной диагонали
	int mD = 0;
	for (i = 0; i < N; i++)
		mD += ApMS[i][i];
	cout << "Main diagonal: " << mD << endl;
	//сумма побочной диагонали
	int sD = 0;
	for (i = 0; i < N; i++)
		sD += ApMS[i][N - i - 1];
	cout << "Subdiagonal: " << sD << endl;
	//если мы докажем, что все найденные суммы по очереди равны одной из них,
	//то они равны между собой. Выберем в качестве эталона главную диагональ
	bool eq = true;
	if (mD != sD) eq = false;
	for (i = 0; i < N; i++)
		if (mD != raws[i] || mD != cols[i])
		{
			eq = false;
			break;
		}
	if (eq) cout << "The magic square found! BEWARE!!!\n";
	else cout << "The square failed.\n";

	cin.get();
	return 0;

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file