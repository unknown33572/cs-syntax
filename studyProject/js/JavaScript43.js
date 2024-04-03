class StackApp {
  constructor(size) {
    this.array = new Array(size);
    this.top = -1;
    this.arraySize = size;
  }

  push(element) {
    if (this.top === this.arraySize - 1) {
      console.log("Stack is full");
      return;
    }
    this.array[++this.top] = element;
  }

  pop() {
    if (this.top === -1) {
      console.log("Stack is empty");
      return;
    }
    return this.array[this.top--];
  }
}

const stack = new StackApp(5);

stack.push(1);
stack.push(2);
stack.push(3);
stack.push(4);
stack.push(5);

console.log(stack.pop());

stack.push(6);

stack.push(7);