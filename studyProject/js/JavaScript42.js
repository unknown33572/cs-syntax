function LinearScan(array, target) {
  var i = 0;
  while (i < array.length) {
    if(array[i] === target) {
      return i;
    }
    i++;
  }
  return -1;
}

console.log(LinearScan([1, 2, 3, 4, 5], 3));

function BinarySearch(array, target) {
  var IndexEnd = array.length - 1;
  var IndexStart = 0;
  while (IndexStart <= IndexEnd) {
    var IndexMiddle = Math.floor((IndexStart + IndexEnd) / 2);

    if (array[IndexMiddle] === target) {
      return IndexMiddle;
    } else if (array[IndexMiddle] < target) {
      IndexStart = IndexMiddle + 1;
    } else {
      IndexEnd = IndexMiddle - 1;
    }
  }
  return -1;
}

console.log(BinarySearch([1, 2, 3, 4, 5], 3));

class LinkedListNode {
  constructor(element) {
    this.element = element;
    this.next = null;
  }
}

function LinkedListLookUp(head, element) {
  let current 
}

LinkedListInsert(linkedListNode: head, Integer: index, Type: value):
  IF index == 0:
    LinkedListNode: new_head = LinkedListNode(value)

    new_head.next = head
    return new_head

    LinkedListNode: current = head
    LinkedListNode: previous = null
    Integer: count = 0
    WHILE count < index AND current != null:
      previous = current
      current = current.next
      count = count + 1

    IF count < index:

    LinkedListNode: new_node = LinkedListNode(value)
    new_node.next = previous.next
    previous.next = new_node

    return head