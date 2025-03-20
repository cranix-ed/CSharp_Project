#include <iostream>

using namespace std;

int main() {
    int n, reverse = 0; // reverse(dao nguoc), remainder(phan du)
    cout << "Enter a positive integer number: ";
    cin >> n;

    if (n <= 0) {
        cout << "Invalid number. Please enter a positive integer number.";
    }
    else {
        for (int i = n; i > 0; i / 10) {
            reverse = reverse * 10 + i % 10;
        }
        if (reverse == n) {
            cout << n << " is a reversible number";
        }
        else {
            cout << n << " is not a reversible number";
        }
    }
    return 0;
}