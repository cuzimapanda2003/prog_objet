#include <iostream>
#include <vector>
using namespace std;

void num3() {
	string name;
	int grade;
	int x = 0;
	do
	{
		cin >> name;
		if (name != "end")
		{

		
		do
		{
			cin >> grade;
		} while (grade > 100 || grade < 0);
		x += grade;
		cout << name << " " << grade << endl;
		}
	} while (name != "end");
	cout << "total grade is " << x;

}

bool num4() {
	vector<int> grades;
	vector<string> names;
	int grade;
	string name;

	while (true) {
		cin >> name;
		if (name == "end") return false;
		else {
			cin >> grade;
		}

	}





}





void main() {

	//#1
	int i = 10;
	float f = 10.22;
	double d = 100.33;
	char c = 'a';
	string s = "Bonjour";
	bool b = true;

	cout << i <<" " << f << " " << d << " " << c << " " << s << " " << b << endl;

	//#2
	int tab[] = { 1, 2, 3, 4, 5 };
	for (int i = 0; i < 5; i++)
	{
		cout << tab[i] << " ";
	}cout << endl;

	//#3
	num3();

	num4();
	






}
