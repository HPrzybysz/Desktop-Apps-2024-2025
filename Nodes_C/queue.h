#ifndef QUEUE_H
#define QUEUE_H

typedef struct QueueNode {
    int data;
    struct QueueNode* next;
} QueueNode;

typedef struct Queue {
    QueueNode* front;
    QueueNode* rear;
} Queue;

Queue* create_queue();
void enqueue(Queue* q, int data);
int dequeue(Queue* q);
int is_empty_queue(Queue* q);
void print_queue(Queue* q);
void free_queue(Queue* q);

#endif // QUEUE_H
