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

  remove() {
    if (this.heap.length <= 1) return null;
    if (this.heap.length === 2) return this.heap.pop();
    const max = this.heap[1];
    this.heap[1] = this.heap.pop();
    let currentIndex = 1;
    let [leftIndex, rightIndex] = [2 * currentIndex, 2 * currentIndex + 1];
    let maxChildIndex = this.heap[rightIndex] && this.heap[rightIndex] > this.heap[leftIndex] ? rightIndex : leftIndex;

    while (this.heap[maxChildIndex] && this.heap[currentIndex] < this.heap[maxChildIndex]) {
      [this.heap[currentIndex], this.heap[maxChildIndex]] = [this.heap[maxChildIndex], this.heap[currentIndex]];
      currentIndex = maxChildIndex;
      [leftIndex, rightIndex] = [2 * currentIndex, 2 * currentIndex + 1];
      maxChildIndex = this.heap[rightIndex] && this.heap[rightIndex] > this.heap[leftIndex] ? rightIndex : leftIndex;
    }
    return max;
  }
}
