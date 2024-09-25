#pragma once
struct Node {
    int data;
    Node* next;
    Node(int value);
};

// Function declarations
void insert(Node*& head, int value);
void insert_start(Node*& head, int value);
void printList(const Node* head);
void deleteList(Node*& head);