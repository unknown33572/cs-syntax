
const dogs = [
  {
    name: 'max',
    weight: '20',
    color: 'black',
    breed: 'labrador',
  },
  {
    name: 'don',
    weight: '40',
    color: 'white',
    breed: 'labrador',
  },
  {
    name: 'shadow',
    weight: '30',
    color: 'brown',
    breed: 'labrador',
  },
  {
    name: 'flower',
    weight: '10',
    color: 'white',
    breed: 'poodle',
  }
];
function getColors(dogs) {
  return dogs.map(dog => dog.color);
}

console.log(getColors(dogs));

function getUniqueColors(attributes) {
  const unique = [];
  for (const attribute of attributes) {
    if (!unique.includes(attribute)) {
      unique.push(attribute);
    }
  }
  return unique;
}

const colors = getColors(dogs);
console.log(getUniqueColors(colors));

function getUniqueColorsSpread(dogs) {
  const unique = new Set();
  for (const dog of dogs) {
    unique.add(dog.color);
  }
  return [...unique];
}

console.log(getUniqueColorsSpread(dogs));

let spreadArr = [...dogs.reduce((colors, { color }) => colors.add(color), new Set())];

console.log(spreadArr);