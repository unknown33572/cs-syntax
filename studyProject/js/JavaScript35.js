function validateCharacterCount(max) {
  const items = Array.prototype.slice.call(arguments, 1);
  return items.every(item => item.length < max);
}

console.log(validateCharacterCount(10, 'wvoquie'));