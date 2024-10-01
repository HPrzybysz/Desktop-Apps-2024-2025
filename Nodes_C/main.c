#include <stdio.h>
#include "list.h"
#include "stack.h"
#include "queue.h"

int main() {

    // Testowanie listy jednokierunkowej

    printf("Testowanie listy jednokierunkowej\n");
    Node* list = create_list();
    append(&list, 1);
    append(&list, 2);
    prepend(&list, 0);
    insert_after(list, 5); // Po pierwszym elemencie
    print_list(list);
    delete_by_value(&list, 5);
    print_list(list);
    append(&list, 212121);
    print_list(list);
    free_list(&list);
    print_list(list);

    // Testowanie stosu

    printf("Testowanie stosu\n");
    StackNode* stack = NULL;
    push(&stack, 1);
    push(&stack, 2);
    push(&stack, 3);
    print_stack(stack);
    printf("Pop: %d\n", pop(&stack));
    print_stack(stack);
    free_stack(&stack);

    // Testowanie kolejki

    printf("Testowanie kolejki\n");
    Queue* queue = create_queue();
    enqueue(queue, 1);
    enqueue(queue, 2);
    enqueue(queue, 3);
    print_queue(queue);
    printf("Dequeue: %d\n", dequeue(queue));
    print_queue(queue);
    free_queue(queue);

    return 0;
}