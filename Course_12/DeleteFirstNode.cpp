#include <iostream>
#include <iomanip>
#include "clsBankClient.h"
#include "clsInputValidate.h"
#include "clsUtil.h"
#include "clsMainScreen.h"
#include "clsCalculator.h"
#include <fstream>
#include <vector>
#include <stack>


using namespace std;

void ReadClientInfo(clsBankClient& Client) 
{
    cout << "First Name : ";
    Client.FirstName = clsInputValidate::ReadString();

    cout << "Last Name : ";
    Client.LastName = clsInputValidate::ReadString();

    cout << "Email : ";
    Client.Email = clsInputValidate::ReadString();

    cout << "Phone : ";
    Client.Phone = clsInputValidate::ReadString();

    cout << "Pin Code : ";
    Client.PinCode = clsInputValidate::ReadString();

    cout << "AccountBallance: ";
    Client.AccountBalance = clsInputValidate::ReadDblNumber("Plz enter a float number : ");

}

//void UpdateClient() 
//{
//    string AccountNumber = "";
//
//    cout << "Plz enter an Account Number: ";
//    AccountNumber = clsInputValidate::ReadString();
//
//    while (!clsBankClient::IsClientExist(AccountNumber)) 
//    {
//        cout << "Account Number is not found, choose another one : ";
//        AccountNumber = clsInputValidate::ReadString();
//
//    }
//
//    clsBankClient Client1 = clsBankClient::Find(AccountNumber);
//    Client1.Print();
//
//    cout << "\n\nUpdate Client Info : ";
//    cout << "\n-----------------------\n";
//
//    ReadClientInfo(Client1);
//}

//void AddNewClient() 
//{
//    string AccountNumber = "";
//
//    cout << "\n Plz enter Account Number : ";
//    AccountNumber = clsInputValidate::ReadString();
//
//    while (clsBankClient::IsClientExist(AccountNumber)) 
//    {
//        cout << "\nAccount Number is already in used, Choose another one : ";
//        AccountNumber = clsInputValidate::ReadString();
//
//    }
//
//    clsBankClient NewClient = clsBankClient::GetAddNewClientObject(AccountNumber);
//
//    ReadClientInfo(NewClient);
//
//    clsBankClient::enSaveResults SaveResult;
//
//    SaveResult = NewClient.Save();
//
//    switch (SaveResult) 
//    {
//    case clsBankClient::enSaveResults::svSucceded:
//        cout << "Account Added Successfully :-)" << endl;
//        NewClient.Print();
//        break;
//    
//    case clsBankClient::enSaveResults::svFaildEmptyObject:
//
//        cout << "Error Account was not saved because it's Empty " << endl;
//        break;
//    
//    case clsBankClient::enSaveResults::svFaildAccountNumberExist:
//
//        cout << "Error Account is Already in used, try another one " << endl;
//        break;
//    
//    }
//
//}

//void DeleteClient() 
//{
//    string AccountNumber = "";
//    cout << "Enter Accout Number : ";
//    AccountNumber = clsInputValidate::ReadString();
//
//    while (!clsBankClient::IsClientExist(AccountNumber)) 
//    {
//        cout << "Client With Account Number is already in used, try another one : " << endl;
//        AccountNumber = clsInputValidate::ReadString();
//
//    }
//
//    clsBankClient Client = clsBankClient::Find(AccountNumber);
//    Client.Print();
//
//    char Answer = 'n';
//
//    cout << "Are you sure you want to delete this client y/n ? ";
//    cin >> Answer;
//
//    if (Answer = 'Y' || Answer == 'y')
//    {
//        if (Client.Delete()) 
//        {
//            cout << "Client Deleted Successfully :-)" << endl; 
//                Client.Print();
//        }
//        else 
//        {
//            cout << "Error Client was not Deleted :-(" << endl;
//        }
//    }
//
//}

//void PrintClientRecordLine(clsBankClient Client) 
//{
//    cout << "| " << left << setw(15) << Client.AccountNumber();
//    cout << "| " << left << setw(20) << Client.FirstName;
//    cout << "| " << left << setw(12) << Client.Phone;
//    cout << "| " << left << setw(20) << Client.Email;
//    cout << "| " << left << setw(8) << Client.PinCode ;
//    cout << "| " << left << setw(12) << Client.AccountBalance;
//    cout << endl << endl;
//}

//void ShowClientsList()
//{
//    vector<clsBankClient> vClients = clsBankClient::GetClientsList();
//
//    cout << "\n\t\t\tClients List (" << vClients.size() << ") Clients" << endl;
//    cout << "-----------------------------------------------------------------"
//        << "--------------------------------------------------\n" << endl;
//
//    cout << "| " << left << setw(15) << "Account Number ";
//    cout << "| " << left << setw(20) << "Client Name ";
//    cout << "| " << left << setw(12) << "Phone ";
//    cout << "| " << left << setw(20) << "Email ";
//    cout << "| " << left << setw(8) << "Pin Code ";
//    cout << "| " << left << setw(12) << "Account Ballances";
//
//    cout << "\n\n-----------------------------------------------------------------"
//        << "---------------------------------------------------\n" << endl;
//    for (clsBankClient &Client : vClients) 
//    {
//        PrintClientRecordLine(Client);
//
//    }
//
//    cout << "\n\n-----------------------------------------------------------------"
//        << "---------------------------------------------------\n" << endl;
//}

//void PrintClientRecordBallanceLine(clsBankClient Client) 
//{
//    cout << "| " << left << setw(15) << Client.AccountNumber();
//    cout << "| " << left << setw(20) << Client.FirstName << "\t\t\t\t\t";
//    cout << "| " << left << setw(40) << Client.AccountBalance;
//    cout << endl << endl;
//}

//void ShowTotalBallances() 
//{
//    vector<clsBankClient> vClients = clsBankClient::GetClientsList();
//
//    cout << "\n\t\t\tClients List (" << vClients.size() << ") Clients" << endl;
//    cout << "-----------------------------------------------------------------"
//        << "--------------------------------------------------\n" << endl;
//
//    cout << "| " << left << setw(15) << "Account Number ";
//    cout << "| " << left << setw(20) << "Client Name " << "\t\t\t\t\t";
//    cout << "| " << left << setw(15) << "Account Ballances";
//
//    cout << "\n\n-----------------------------------------------------------------"
//        << "---------------------------------------------------\n" << endl;
//    
//    int totalBallances = 0;
//
//    for (clsBankClient& Client : vClients)
//    {
//        PrintClientRecordBallanceLine(Client);
//
//        totalBallances += Client.AccountBalance;
//    }
//
//    cout << "\n\n-----------------------------------------------------------------"
//        << "---------------------------------------------------\n" << endl;
//
//    cout << "\t\t\t\t" << "Total Ballances  = " << totalBallances  << endl;
//    cout << "\t\t\t\t("  << clsUtil::ConvertNumberToText(totalBallances) << ")" << endl;
//
//
//}

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

    DeleteFirstNode(head);

    PrintList(head);

    return 0;
}