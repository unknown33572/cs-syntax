//function validateCharacterCount(max) {
//  const items = Array.prototype.slice.call(arguments, 1);
//  return items.every(item => item.length < max);
//}

//console.log(validateCharacterCount(10, 'wvoquie'));

//const discounter = d => p => p * (1 - d);
//const tenPercentOff = discounter(0.1);
//console.log(discounter(0.1)(100));

function mergeProgramInfo(building, manager) {
  const { hours, address } = building;
  const { name, phone } = manager;
  const defaults = {
    hours,
    address,
    contact: name,
    phone
  };

  return x => { // 두 번째 함수 커링 처리
    return { ...defaults, ...x };
  }
}

const building = {
  hours: '8 a.m. - 8 p.m.',
  address: 'Jayhawk Blvd'
};

const manager = {
  name: 'Augusto',
  phone: '555-5555'
};

const program = {
  name: 'Presenting Research',
  room: '415',
  hours: '3 - 6 p.m.'
};

const exhibit = {
  name: 'Emerging Scholarship',
  contact: 'Dana'
}

const exhibitInfo = mergeProgramInfo(building, manager)(exhibit);

const programInfo = mergeProgramInfo(building, manager)(program);

console.log(programInfo);
console.log(exhibitInfo);