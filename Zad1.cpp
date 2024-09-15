#include <iostream>
#include <cmath>
#include <iomanip>
#include <vector>

using namespace std;

float quad_eq(float a, float b, float c){
	
	float delta = pow(b, 2) - 4 * c;
	vector<float>array;
	
	if (delta < 0) {

	}
	else if (delta == 0) {
		float x0 = (b / (2 * a)) * -1;
		array.push_back(x0);

	}
	else {
		float x1 = ((b * -1) - (sqrt(delta) * -1)) / 2 * a;
		float x2 = ((b * -1) + (sqrt(delta) * -1)) / 2 * a;

		array.push_back(x1);
		array.push_back(x2);
	}

	return array;

}

int main() {

	quad_eq(1, 4, -5);
	cout << "This equals: " << endl;
	for (double val : array) {
		cout << val + " ";
	}

	return 0;
}