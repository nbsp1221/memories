#include "tfidf.hpp"

#include <iostream>
#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

int main()
{
	// Documents information
	vector<string> documents = {
		"do you like apples i like apples so much we have many apples",
		"what are you doing now i am developing my programs can you do this",
		"programming is very hard but it is so fun i want to learn deep learning"
	};

	// Set a splitter
	tfidf tfidfClass(" ");

	// Set documents and calculate tf-idf
	tfidfClass.setDocuments(documents);

	// Print results
	for (size_t i = 0; i < documents.size(); i++) {
		vector<pair<string, double>> result = tfidfClass.toVector(i);
		cout << "[File " << i + 1 << "] " << documents[i] << endl;

		for (const auto& info : result) {
			cout << " * " << info.first << ": " << info.second << endl;
		}

		cout << endl;
	}

	return 0;
}