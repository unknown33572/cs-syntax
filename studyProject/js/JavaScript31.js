/*
const prices = ['1.0', '2.15', '3.0'];

const formattedPrices = [];

for (let i = 0; i < prices.length; i++) {
  formattedPrices.push(parseFloat(prices[i]));
}

console.log(formattedPrices);
*/

/*
const prices = ['1.0', 'negotiable', '3.0'];

const formattedPrices = [];

for (let i = 0; i < prices.length; i++) {
  const price = parseFloat(prices[i]);
  if (price) {
    formattedPrices.push(price); // negotiable is not a number, so it will be ignored
  }
}

console.log(formattedPrices);
*/

function getCareerInfo(person) {
  return person.role;
}


const team = [
  { name: 'Sara', role: 'Frontend' },
  { name: 'John', role: 'Backend' },
  { name: 'Jane', role: 'Frontend' },
  { name: 'Tom', role: 'Backend' },
  { name: 'Sally', role: 'DBA' }
];

/*
const careerInfo = [];

for (let i = 0; i < team.length; i++) {
  careerInfo.push(getCareerInfo(team[i]));
}

console.log(careerInfo);
*/

//const careerInfo = team.map(getCareerInfo);

const careerInfo = team.map(person => person.role);

console.log(careerInfo);

const backendTeam = team.filter(role => role.role === 'Backend');

console.log(backendTeam);