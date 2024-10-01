#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

Queue* create_queue() {
    Queue* q = (Queue*)malloc(sizeof(Queue));
    q->front = NULL;
    q->rear = NULL;
    return q;
}

// Dodaniedo kolejki (enqueue)
void enqueue(Queue* q, int data) {
    QueueNode* new_node = (QueueNode*)malloc(sizeof(QueueNode));
    new_node->data = data;
    new_node->next = NULL;

    if (q->rear == NULL) {
        q->front = q->rear = new_node;
        return;
    }

    q->rear->next = new_node;
    q->rear = new_node;
}

//delete
int dequeue(Queue* q) {
    if (q->front == NULL) {
        printf("Kolejka jest pusta.\n");
        return -1;
    }

    QueueNode* temp = q->front;
    int dequeued = temp->data;
    q->front = q->front->next;

    if (q->front == NULL) {
        q->rear = NULL;
    }

    free(temp);
    return dequeued;
}

//is pusta?
int is_empty_queue(Queue* q) {
    return q->front == NULL;
}

//wyswwietlenie kolejki
void print_queue(Queue* q) {
    QueueNode* temp = q->front;
    while (temp != NULL) {
        printf("%d -> ", temp->data);
        temp = temp->next;
    }
    printf("NULL\n");
}

// Zwalnianiepamięci
void free_queue(Queue* q) {
    QueueNode* current = q->front;
    QueueNode* next;

    while (current != NULL) {
        next = current->next;
        free(current);
        current = next;
    }

    free(q);
}