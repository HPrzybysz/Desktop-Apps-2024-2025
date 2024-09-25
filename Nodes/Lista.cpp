#include "Lista.h"
#include <iostream>

using namespace std;

Node::Node(int value) : data(value), next(nullptr) {}

void insert(Node*& head, int value) {
	Node* newNode = new Node(value);
	if (!head) {
		head = newNode;
	}
	else {
		Node* temp = head;
		while (temp->next) {
			temp = temp->next;
		}
		temp->next = newNode;
	}
}


void insert_start(Node*& head, int value) {
	Node* newNode = new Node(value);
	newNode->next = head;
	head = newNode;
}

void printList(const Node* head) {
	const Node* temp = head;
	while (temp) {
		cout << temp->data << " -> ";
		temp = temp->next;
	}
	cout << "nullptr" << endl;
}

void deleteList(Node*& head) {
	Node* current = head;
	while (current != nullptr) {
		Node* next = current->next;
		delete current;
		current = next;
	}
	head = nullptr;
}
