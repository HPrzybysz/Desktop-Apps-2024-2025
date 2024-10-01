#include <stdio.h>
#include <stdlib.h>
#include "stack.h"

// dodanie elementu
void push(StackNode** top, int data) {
    StackNode* new_node = (StackNode*)malloc(sizeof(StackNode));
    new_node->data = data;
    new_node->next = *top;
    *top = new_node;
}

//usuniecie elementu ze stosu (pop)
int pop(StackNode** top) {
    if (*top == NULL) {
        printf("Stos jest pusty.\n");
        return -1;
    }

    StackNode* temp = *top;
    int popped = temp->data;
    *top = (*top)->next;
    free(temp);

    return popped;
}

// Sprawdzenie górnego elementu stosu (peek)
int peek(StackNode* top) {
    if (top == NULL) {
        printf("Stos jest pusty.\n");
        return -1;
    }
    return top->data;
}

// sprawdzanie czy pusty
int is_empty(StackNode* top) {
    return top == NULL;
}

// wyswietlenie calego stosu
void print_stack(StackNode* top) {
    StackNode* temp = top;
    while (temp != NULL) {
        printf("%d -> ", temp->data);
        temp = temp->next;
    }
    printf("NULL\n");
}

//zwalnianie pamięci
void free_stack(StackNode** top) {
    StackNode* current = *top;
    StackNode* next;

    while (current != NULL) {
        next = current->next;
        free(current);
        current = next;
    }

    *top = NULL;
}