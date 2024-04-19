function hashTable(size) {
  this.size = size;
  this.bins = new Array(size).fill(null);
}

function ListNode(key, value) {
  this.key = key;
  this.value = value;
  this.next = null;
}

hashTable.prototype.hashFunction = function(key) {
  return key % this.size;
};

hashTable.prototype.insert = function(key, value) {
  const index = this.hashFunction(key);
  let current = this.bins[index];

  if(!current) {
    this.bins[index] = new ListNode(key, value);
    return;
  }

  while(current.next && current.key !== key) {
    current = current.next;
  }

  if(current.key === key) {
    current.value = value;
  } else {
    current.next = new ListNode(key, value);
  }
};

hashTable.prototype.lookup = function(key) {
  const index = this.hashFunction(key);
  let current = this.bins[index];

  while (current) {
    if (current.key === key) {
      return current.value;
    }
    current = current.next;
  }
  return null;
};

hashTable.prototype.remove = function(key) {
  const index = this.hashFunction(key);
  let current = this.bins[index];
  let prev = null;

  while (current) {
    if (current.key == key) {
      if(prev) {
        prev.next = current.next;
      } else {
        this.bins[index] = current.next;
      }
      return true;
    }
  }
  return false;
};

var ht = new hashTable(10);

ht.insert(0, 'zero');
ht.insert(1, 'one');
ht.insert(2, 'two');
ht.insert(3, 'three');
ht.insert(10, 'ten');

console.log(ht.bins);
