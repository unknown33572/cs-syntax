const filter = [{
  색상: '검정',
  견종: '래브라도레트리버'
}, {
  색상: '갈색',
  견종: '포메라이언'
}];

function getAppliedFilters(filter) {
  const keys = Object.keys(filter);
  const applied = [];
  for (const key of keys) {
    applied.push(`${key}: ${filter[key]}`);
  }
  return `선택한 조건은 ${applied.join(', ')} 입니다.`;
}

filter.map(obj => getAppliedFilters(obj)).forEach(result => console.log(result));

const filters = new Map().set('색상', '흰색').set('견종', '말티즈');

function checkFilters(filters) {
  const applied = [];
  for (const [key, value] of filters) {
    applied.push(`${key}: ${value}`);
  }
  return `선택한 조건은 ${applied.join(', ')} 입니다.`;
}

console.log(checkFilters(filters));