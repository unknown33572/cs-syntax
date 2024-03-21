const dogs = [
  {
    name: 'max',
    weight: '20',
    breeds: 'boston terrier',
  },
  {
    name: 'don',
    weight: '50',
    breeds: 'labrador',
  },
  {
    name: 'shadow',
    weight: '10',
    breeds: 'maltese',
  },
];

function getDogNames(dogs, func) {
  //const [key, value] = filter;
  //return dogs.filter(dog => dog[key] <= value).map(dog => dog.name);
  return dogs.filter(func).map(dog => dog.name);
}

//console.log(getDogNames(dogs, ['weight', '20']));

const weightCheck = weight => dog => dog['weight'] >= weight;

console.log(getDogNames(dogs, weightCheck(50)));