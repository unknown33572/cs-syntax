class Vaildator {
  constructor() {
    this.message = '(이)가 유효하지 않습니다.';
    this.setInvalidMessage = field => `${field}${this.message}`;
  }
  setInvalidMessages(...fields) {
    return fields.map(this.setInvalidMessage);
  }
}

const validator = new Vaildator();

console.log(validator.setInvalidMessages('도시', '음식'));