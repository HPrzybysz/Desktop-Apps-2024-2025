#include <stdio.h>
#include <stdlib.h>
#include "list.h"

Node* create_list() {
    return NULL;
}

// Dodanie na końcu
void append(Node** head, int data) {
    Node* new_node = (Node*)malloc(sizeof(Node));
    new_node->data = data;
    new_node->next = NULL;

    if (*head == NULL) {
        *head = new_node;
        return;
    }

    Node* temp = *head;
    while (temp->next != NULL) {
        temp = temp->next;
    }

    temp->next = new_node;
}

// Dodanie na początku
void prepend(Node** head, int data) {
    Node* new_node = (Node*)malloc(sizeof(Node));
    new_node->data = data;
    new_node->next = *head;
    *head = new_node;
}

// Wstawienie po określonym elemencie
void insert_after(Node* prev_node, int data) {
    if (prev_node == NULL) {
        printf("Poprzedni węzeł nie może być NULL.\n");
        return;
    }

    Node* new_node = (Node*)malloc(sizeof(Node));
    new_node->data = data;
    new_node->next = prev_node->next;
    prev_node->next = new_node;
}

// Usuwanie
void delete_by_value(Node** head, int data) {
    Node* temp = *head;
    Node* prev = NULL;

    if (temp != NULL && temp->data == data) {
        *head = temp->next;
        free(temp);
        return;
    }

    while (temp != NULL && temp->data != data) {
        prev = temp;
        temp = temp->next;
    }

    if (temp == NULL) return;

    prev->next = temp->next;
    free(temp);
}

// Wyszukanie
Node* search(Node* head, int data) {
    Node* current = head;
    while (current != NULL) {
        if (current->data == data) {
            return current;
        }
        current = current->next;
    }
    return NULL;
}

// Drukowanie całej listy
void print_list(Node* head) {
    Node* temp = head;
    while (temp != NULL) {
        printf("%d -> ", temp->data);
        temp = temp->next;
    }
    printf("NULL\n");
}

// Zwalnianie pamięci
void free_list(Node** head) {
    Node* current = *head;
    Node* next;

    while (current != NULL) {
        next = current->next;
        free(current);
        current = next;
    }

    *head = NULL;
}