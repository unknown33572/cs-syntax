let hometown = [
  {name: '이순신', place: '일산', city: '경기도'},
  {name: '홍길동', place: '과천'},
  {name: '을지문덕', place: '광주', city: '전라도'},
  {name: '척준경', place: '부산', city: '경상도'}
];

let isHometown = function (h, name) {
  if (h.hasOwnProperty('city')) {
    console.log(`찾기 함수가 호출되었습니다. ${h.city} ${h.place}에서 ${name}을 찾습니다.`);
  } else {
    console.log(`찾기 함수가 호출되었습니다. ${h.place}에는 city 정보가 없습니다.`);
    console.log(`이어서 ${h.place}에서 ${name}을 찾습니다.`);
  }

  if (h.name === name) {
    console.log(`${name}의 고향은 ${h.city} ${h.place}입니다.`);
    return true;
  } else {
    console.log(`${name}의 고향은 ${h.place}이(가) 아닙니다.`);
    return false;
  }
}

let h;

while (h = hometown.shift()) {
  if (!h.name || !h.place) continue;

  let result = isHometown(h, '을지문덕');
  if (result) break;
}