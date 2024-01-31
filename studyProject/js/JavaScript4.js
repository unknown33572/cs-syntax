function getRandomInteger(min, max) {
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

function rspPlayer(userRsp) {
  const rsp = ["가위", "바위", "보"];
  const playRsp = rsp[getRandomInteger(0, 2)];

  if (userRsp == playRsp) {
    return {
      userRsp: userRsp,
      playRsp: playRsp,
      winner: 0,
    };
  } else if (userRsp == "가위") {
    if (playRsp == "보") {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: 1,
      };
    } else {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: -1,
      };
    }
  } else if (userRsp == "바위") {
    if (playRsp == "가위") {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: 1,
      };
    } else {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: -1,
      };
    }
  } else if (userRsp == "보") {
     if (playRsp == "바위") {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: 1,
      };
    } else {
      return {
        userRsp: userRsp,
        playRsp: playRsp,
        winner: -1,
      };
    }
}
}


let result = rspPlayer("바위");
console.log(result);