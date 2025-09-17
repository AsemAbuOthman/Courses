class Node 
{
public:
    int value;
    Node* next;
};

void InsertingAtTheBegining(Node* &head, int value) 
{

    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = head;

    head = new_node;
}

Node* Find(Node* head, int value) 
{
    while (head != NULL) 
    {
        if (head->value == value) 
        {
            return head;
        }

        head = head->next;
    }

    return NULL;
}

void InsertAfter(Node* prev_node, int value) 
{

    if (prev_node == NULL) 
    {
        cout << "The Given previous Node is can't be NULL !" << endl;
        return;
    }

    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = prev_node->next;

    prev_node->next = new_node;
}

void InsertAtEnd(Node* &head, int value) 
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = NULL;

    if (head == NULL) 
    {
        head = new_node;
        return;
    }

    Node* LastNode = head;

    while (LastNode->next != NULL) 
    {
        LastNode = LastNode->next;
    }

    LastNode->next = new_node;
  
    return;
}

void DeleteNode(Node*& head, int value)
{
    Node* current, * prev;

    current = prev = head;

    if (head == NULL)
    {
        return;
    }

    if (current->value == value) 
    {
        head = current->next;
        delete current;

        return;
    }

    while(current->value != value && current != NULL) 
    {
        prev = current;
        current = current->next;
    }

    if (current == NULL) 
    {
        return;
    }

    prev->next = current->next;
    delete current;

}

void DeleteFirstNode(Node* &head) 
{
    Node* current = head;

    if (head == NULL) 
    {
        return;
    }

    head = current->next;
    delete current;
}

void DeleteLastNode(Node* &head) 
{
    Node* current, * prev;

    current = prev = head;

    if (head == NULL) 
    {
        return;
    }

    if (current->next == NULL) 
    {
        head = NULL;
        delete current;
        
        return;
    }

    while (current != NULL && current->next != NULL) 
    {
        prev = current;
        current = current->next;
    }

    prev->next = NULL;
    delete current;
}

void PrintList(Node *head) 
{

    while (head != NULL) 
    {
        cout << head->value << " ";
        head = head->next;
    }

    cout << endl;
}

int main()
{
    //clsMainScreen::ShowMainMenu();
 
    
    Node* head = NULL;

    InsertAtEnd(head, 1);
    InsertAtEnd(head, 2);
    InsertAtEnd(head, 3);
    InsertAtEnd(head, 4);
    InsertAtEnd(head, 5);
    InsertAtEnd(head, 6);


    PrintList(head);

    DeleteLastNode(head);

    PrintList(head);

    return 0;
}