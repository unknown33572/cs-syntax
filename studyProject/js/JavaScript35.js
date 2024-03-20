//function validateCharacterCount(max) {
//  const items = Array.prototype.slice.call(arguments, 1);
//  return items.every(item => item.length < max);
//}

//console.log(validateCharacterCount(10, 'wvoquie'));

const discounter = d => p => p * (1 - d);
const tenPercentOff = discounter(0.1);
console.log(discounter(0.1)(100));