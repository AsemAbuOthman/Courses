
class Node 
{
public:
    int value;
    Node* next;
    Node* prev;
};

void PrintList(Node* head) 
{
    while (head != NULL)
    {
        cout << head->value << " ";
        head = head->next;
    }
    cout << endl;
}

void InsertAtBegining(Node* &head, int value)
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = head;
    new_node->prev = NULL;

    if (head != NULL)
    {
        head->prev = new_node;
    }

    head = new_node;
}

Node* FindNode(Node* head, int value) 
{

    if (head == NULL) 
    {
        return NULL;
    }

    while (head != NULL && head->value != value)
    {
        head = head->next;
    }

    return head;
}

void InsertAfter(Node* current, int value) 
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->prev = current->prev;
    new_node->next = current->next;

    if (current->next != NULL)
    {
        current->next->prev = new_node;
    }

    current->next = new_node;
}

void InsertAtEnd(Node* head, int value)
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = NULL;

    if (head == NULL) 
    {
        new_node->prev = NULL;
        head = new_node;
    }
    else 
    {
        Node* current = head;

        while (current->next != NULL)
        {
            current = current->next;
        }

        current->next = new_node;
        new_node->prev = current;

    }
}

int main()
{
    //clsMainScreen::ShowMainMenu();
 
    Node* head = NULL;

    InsertAtBegining(head, 1);
    //InsertAtBegining(head, 2);
    //InsertAtBegining(head, 3);

    //Node* node = FindNode(head, 1);

    InsertAtEnd(head, 0);

    PrintList(head);

    return 0;
}