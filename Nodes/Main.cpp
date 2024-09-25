#include "Lista.h"
#include <iostream>

using namespace std;

int main() {

	Node* head = nullptr;

	insert(head, 10);
	insert(head, 20);
	insert(head, 5);
	insert(head, 53);

	insert_start(head, 37);
	insert_start(head, 21);

	insert(head, 11);

	printList(head);

	deleteList(head);

	return 0;
}