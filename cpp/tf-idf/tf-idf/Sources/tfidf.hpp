#pragma once

#include <string>
#include <vector>
#include <unordered_map>
#include <algorithm>

class tfidf
{
public:
	using token_type = std::string;
	using tokenizer_type = std::string;
	using tfidf_type = std::pair<token_type, double>;
	using tfidf_table = std::unordered_map<token_type, double>;

	tfidf(const tokenizer_type& tokenizer);

	void setDocuments(token_type documents[], std::size_t size);
	void setDocuments(const std::vector<token_type>& documents);

	std::vector<tfidf_type> toVector(std::size_t index) const;
	std::vector<tfidf_table> getResult() const;

private:
	tokenizer_type tokenizer;

	std::vector<tfidf_table> tfsList;
	std::vector<tfidf_table> tfidfsList;
	
	void tfCalc(token_type document);
	double idfCalc(const token_type token);
	void tfidfCalc();

	token_type getToken(const token_type& document);
	void nextToken(token_type& document);
	std::size_t getDocumentFreq(const token_type& token);
};

//==================================================
// Public
//==================================================

tfidf::tfidf(const tokenizer_type& tokenizer)
{
	this->tokenizer = tokenizer;
}

void tfidf::setDocuments(token_type documents[], std::size_t size)
{
	for (std::size_t i = 0; i < size; i++) {
		tfCalc(documents[i]);
	}

	tfidfCalc();
}

void tfidf::setDocuments(const std::vector<token_type>& documents)
{
	for (const auto& document : documents) {
		tfCalc(document);
	}

	tfidfCalc();
}

std::vector<tfidf::tfidf_type> tfidf::toVector(std::size_t index) const
{
	std::vector<tfidf_type> result;

	for (const auto& tfidf : this->tfidfsList[index]) {
		result.push_back(tfidf);
	}

	// Sort tf-idf in descending order
	std::sort(result.begin(), result.end(), [] (const tfidf_type& first, const tfidf_type& second) -> bool {
		return first.second > second.second;
	});

	return result;
}

std::vector<tfidf::tfidf_table> tfidf::getResult() const
{
	return this->tfidfsList;
}

//==================================================
// Private
//==================================================

void tfidf::tfCalc(token_type document)
{
	std::unordered_map<token_type, std::size_t> tokenCountList;
	std::size_t tokenCountMax = 1;

	while (!document.empty()) {
		token_type token = getToken(document);

		if (tokenCountList.find(token) == tokenCountList.end()) {
			tokenCountList[token] = 1;
		}
		else {
			tokenCountMax = std::max(tokenCountMax, ++tokenCountList[token]);
		}

		nextToken(document);
	}

	tfidf_table tfs;

	for (const auto& tokenCount : tokenCountList) {
		tfs[tokenCount.first] = 0.5 + 0.5 * (double)tokenCount.second / (double)tokenCountMax;
	}

	this->tfsList.push_back(tfs);
}

double tfidf::idfCalc(const token_type token)
{
	std::size_t documentCount = this->tfsList.size();
	return log((double)documentCount / (double)getDocumentFreq(token));
}

void tfidf::tfidfCalc()
{
	for (const auto& tfs : this->tfsList) {
		tfidf_table tfidfs;

		for (const auto& tf : tfs) {
			tfidfs[tf.first] = tf.second * idfCalc(tf.first);
		}

		this->tfidfsList.push_back(tfidfs);
	}

	this->tfsList.clear();
}

tfidf::token_type tfidf::getToken(const token_type& document)
{
	std::size_t index = document.find(tokenizer);
	return index == std::string::npos ? document : document.substr(0, index);
}

void tfidf::nextToken(token_type& document)
{
	std::size_t index = document.find(tokenizer);
	
	if (index == std::string::npos) {
		document.clear();
	}
	else {
		document = document.substr(index + this->tokenizer.size());
	}
}

// Get the number of documents where the token exists
std::size_t tfidf::getDocumentFreq(const token_type& token)
{
	std::size_t count = 0;

	for (const auto& tfs : this->tfsList) {
		count += tfs.count(token);
	}

	return count;
}