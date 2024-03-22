function* getColor() { // generator function
    yield 'red';
    yield 'green';
    yield 'blue';
}

const colorGen = getColor();

console.log(colorGen.next());
console.log(colorGen.next());
console.log(colorGen.next());
console.log(colorGen.next());

const addedColor = {
  'purple': true,
  'orange': false,
};

for (const color of getColor()) {
  if(color === 'green')
  addedColor[color] = false;
}

console.log(addedColor);

// 기여도 늘리기
// 기여도 늘리기