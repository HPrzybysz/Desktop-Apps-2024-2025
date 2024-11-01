#ifndef LIST_H
#define LIST_H

typedef struct Node {
    int data;
    struct Node* next;
} Node;

Node* create_list();
void append(Node** head, int data);
void prepend(Node** head, int data);
void insert_after(Node* prev_node, int data);
void delete_by_value(Node** head, int data);
Node* search(Node* head, int data);
void print_list(Node* head);
void free_list(Node** head);

#endif // LIST_H