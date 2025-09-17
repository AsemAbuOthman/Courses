
#include <iostream>
#include <fstream>
#include <sstream>
#include <vector>
#include <map>
#include <cmath>
#include <string>
#include <algorithm>
#include <cctype>
#include <unordered_set>

using namespace std;


string RemoveStopWords(string word)
{
    string arrStopWords[] = {

        "a", "about", "above", "after", "again", "against", "ain", "all", "am", "an", "and", "any", "are", "aren", "aren't",
        "as", "at", "be", "because", "been", "before", "being", "below", "between", "both", "but", "by", "can", "couldn",
        "couldn't", "d", "did", "didn", "didn't", "do", "does", "doesn", "doesn't", "doing", "don", "don't", "down", "during",
        "each", "few", "for", "from", "further", "had", "hadn", "hadn't", "has", "hasn", "hasn't", "have", "haven", "haven't",
        "having", "he", "her", "here", "hers", "herself", "him", "himself", "his", "how", "i", "if", "in", "into", "is", "isn",
        "isn't", "it", "it's", "its", "itself", "just", "ll", "m", "ma", "me", "mightn", "mightn't", "more", "most", "mustn",
        "mustn't", "my", "myself", "needn", "needn't", "no", "nor", "not", "now", "o", "of", "off", "on", "once", "only", "or",
        "other", "our", "ours", "ourselves", "out", "over", "own", "re", "s", "same", "shan", "shan't", "she", "she's", "should",
        "should've", "shouldn", "shouldn't", "so", "some", "such", "t", "than", "that", "that'll", "the", "their", "theirs", "them",
        "themselves", "then", "there", "these", "they", "this", "those", "through", "to", "too", "under", "until", "up", "ve", "very",
        "was", "wasn", "wasn't", "we", "were", "weren", "weren't", "what", "when", "where", "which", "while", "who", "whom", "why",
        "will", "with", "won", "won't", "wouldn", "wouldn't", "y", "you", "you'd", "you'll", "you're", "you've", "your", "yours",
        "yourself", "yourselves"

    };

    for (string& StopWords : arrStopWords)
    {
        if (StopWords == word)
        {
            return "";
        }
    }

    return word;
}

unordered_set<string> Tokenize(const string& text) {

    unordered_set<string> tokens;
    stringstream ss(text);
    string token;

    while (ss >> token) {

        transform(token.begin(), token.end(), token.begin(), ::tolower);

        token = RemoveStopWords(token);

        token.erase(remove_if(token.begin(), token.end(), ::ispunct), token.end());

        if (!token.empty()) {
            tokens.insert(token);
        }
    }
    return tokens;
}

void ComputeTFIDF(const vector<string>& documents, map<string, double>& termIDF, map<int, map<string, double>>& tfidfMatrix) {

    map<string, map<int, double>> tf;
    map<string, int> docFrequency;

    for (int i = 0; i < documents.size(); ++i) {

        unordered_set<string> tokens = Tokenize(documents[i]);
        map<string, int> termCount;

        for (const string& token : tokens) {

            termCount[token]++;

        }

        for (const auto& pair : termCount) {

            tf[pair.first][i] = (double)pair.second / tokens.size();
            docFrequency[pair.first]++;

        }
    }

    for (const auto& pair : docFrequency) {

        termIDF[pair.first] = log((double)documents.size() / (1 + pair.second));

    }

    for (const auto& termPair : tf) {

        const string& term = termPair.first;

        for (const auto& docPair : termPair.second) {

            int docIndex = docPair.first;
            double termFreq = docPair.second;
            double idf = termIDF[term];

            //cout << "Document " << docIndex << ", Term: " << term << ", TF-IDF: " << (termFreq * idf) << endl;
            tfidfMatrix[docIndex][term] = termFreq * idf;
        }
    }
}

vector<string> ReadDocumentLines(string fileName, int howManyInstance)
{
    fstream file;
    string line = "";
    vector<string> vDocuments;

    file.open(fileName, ios::in);

    int counter = 1;

    if (file.is_open())
    {
        while (getline(file, line) && counter <= howManyInstance)
        {
            vDocuments.push_back(line);

            counter++;
        }

        file.close();
    }

    return vDocuments;
}

int main() {

    /*ifstream file("IMDB Dataset.txt");
    vector<string> documents;
    string line;

    int howManyInstance = 0;

    while (getline(file, line) && howManyInstance <= 1000) {

        documents.push_back(line);

        howManyInstance++;
    }

    file.close();*/

    vector<string> documents = ReadDocumentLines("IMDB Dataset.txt", 100);


    map<string, double> termIDF;

    ofstream csvFile("imdb_reviews_features.csv");

    for (const auto& term : termIDF) {

        csvFile << term.first << ",";

    }

    csvFile << endl;


    map<int, map<string, double>> tfidfMatrix;

    ComputeTFIDF(documents, termIDF, tfidfMatrix);

    for (int i = 0; i < documents.size(); ++i) {

        for (const auto& term : termIDF) {

            auto it = tfidfMatrix[i].find(term.first);

            if (it != tfidfMatrix[i].end()) {

                csvFile << it->second << ",";

            }

            else {

                csvFile << "0,";
            }
        }

        csvFile << endl;
    }

    cout << "\nDone\n\n";

    csvFile.close();

    return 0;
}
