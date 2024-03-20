//const instructors = [
//  { name: 'Quincy', libraries: ['Quantum Mechanics'] },
//  { name: 'Kenn', libraries: ['Norse Mythology'] },
//  { name: 'Paul', libraries: ['Tuvan throat singing'] },
//  { name: 'Aaron', libraries: ['Entomology', 'Kung Fu'] },
//];

//const findInstructor = instructors.find(instructor => {
//  return instructor.libraries.includes('Entomology');
//});

//console.log(findInstructor);

//const findByLibrary = library => instructors => {
//  return instructors.libraries.includes(library);
//};

//const librarian = instructors.find(findByLibrary('Kung Fu'));

//console.log(librarian);

const sailors = [
  {
    name: 'Jim',
    active: true,
    email: 'jim@gmail.com'
  },
  {
    name: 'Sally',
    active: true,
    email: 'sally@naver.com'
  },
  {
    name: 'Tom',
    active: false,
    email: ''
  }
];

const activeSailors = sailors.filter(sailor => sailor.active);

//console.log(activeSailors);

const emails = activeSailors.filter(sailor => sailor.email && sailor.email.includes('@gmail.com'));

console.log(emails);