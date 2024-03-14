const capitalize = name => name[0].toUpperCase() + name.slice(1);

function greet(name) {
  return `Hello, ${name}`;
}

function applyCustomGreeting(name, callback) {
  return callback(capitalize(name));
}

console.log(applyCustomGreeting('mark', greet)); // applyCustomGreeting -> greet -> capitalize