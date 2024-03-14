const UC = {
}

const UC2 = {
  images: []
}

const UC3 = {
  images: [
    'image1.jpg',
    'image2.jpg',
  ]
}

//const imgCheck = UC.images[0] || 'default.jpg';

//console.log(imgCheck);

function getFirstImage(uc) {
  let img = 'default.jpg';
  if (UC.images) {
    img = UC.images[0];
  }

  return img;
}

console.log(getFirstImage(UC2));

function exampleCallback(callback) {
  // 무언가 작업 수행
  console.log("작업 완료");
  callback();
}

exampleCallback(function () {
  console.log("콜백 함수 실행됨");
});