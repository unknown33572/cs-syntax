class TrieNode {
  constructor() {
    this.children = {};
    this.isEndOfWord = false;
  }

  insert(word) {
    let current = this;
    for(const ch of word) {
      if(!current.children[ch]) {
        current.children[ch] = new TrieNode();
      }
      current = current.children[ch];
    }
    current.isEndOfWord = true;
  }

  search(word) {
    let current = this;
    for (const ch of word) {
      if (!current.children[ch]) {
        return false;
      }
      current = current.children[ch];
    }
  }
}