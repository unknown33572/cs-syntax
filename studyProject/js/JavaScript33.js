//const callback = function (collectedValues, item) {
//  return [...collectedValues, item];
//};

//const saying = ['veni', 'vedi', 'veci'];

//const initialValue = [];

//const result = saying.reduce(callback, initialValue, 2);

//console.log(result);

//const numbers = [1, 2, 3, 4, 5];
//const sum = numbers.reduce((accumulator, currentValue) => accumulator + currentValue , 10);
//console.log(sum);

const dogs = [
  {
    이름: '맥스',
    크기: '소형견',
    견종: '보스턴 테리어',
    색상: '검정색'
  },
  {
    이름: '도니',
    크기: '대형견',
    견종: '래브라도레트리버',
    색상: '검정색'
  },
  {
    이름: '섀도',
    크기: '중형견',
    견종: '래브라도레트리버',
    색상: '갈색'
  }
];

const colors = dogs.reduce((colors, dog) => {
  if (colors.includes(dog['색상'])) {
    return colors;
  }
  return [...colors, dog['색상']];
}, []);

console.log(colors);

const object = { a: 1, b: 2, c: 3 };

for (const keyValue in object) {
  console.log(object[keyValue]);
}