function makeRice() {
  return new Promise((resolve) => {
    setTimeout(() => {
      console.log("밥이 완성되었습니다.")
      resolve();
    }, 1000);
  });
}

function makeSoup() {
  return new Promise((resolve) => {
    setTimeout(() => {
      console.log("국이 완성되었습니다.")
      resolve();
    }, 1000);
  });
}

function makeEgg() {
  return new Promise((resolve) => {
    setTimeout(() => {
      console.log("후라이가 완성되었습니다.")
    }, 1000);
    resolve();
  }).then(() => {
    console.log("게임중");
  });
}

async function cookMeal() {
  await Promise.all([makeRice(), makeSoup(), makeEgg()]);
  console.log("모든 요리가 완성되었습니다.");
}

cookMeal();