const cart = [{
  name: 'The Foundation Triology',
  price: 19.99,
  discount: false
},
{
  name: 'Godel, Escher, Bach',
  price: 15.99,
  discount: false
},
{
  name: 'Red Mars',
  price: 5.99,
  discount: true
},
];

const reward = {
  name: 'Guide to Science Fiction',
  discount: true,
  price: 0
};

function addFreeGift(cart) {
  if (cart.length > 2) {
    cart.push(reward);
    return cart;
  }
  return cart;
}

function summarizeCart(cart) {
  const discountable = cart.filter(item => item.discount);
  if (discountable.length > 1) {
    return {
      error: 'Can only have one discount'
    };
  }
  const cartWithReward = addFreeGift(cart);
  return {
    discounts: discountable.length,
    items: cartWithReward.length,
    cart: cartWithReward,
  };
}

console.log(summarizeCart(cart));

function summarizeCartUpdated(cart) {
  const cartWithReward = addFreeGift(cart);
  const discountable = cart.filter(item => item.discount);
  if (discountable.length > 1) {
    return {
      error: '할인 상품은 하나만 가능합니다.'
    };
  }
  return {
    discounts: discountable.length,
    items: cartWithReward.length,
    cart: cartWithReward,
  };
}


function getBill(item) {
  return {
    name: item.name,
    due: twoWeeksfromNow(),
    total: calculateTotal(item.price),
  };
}

const bill = getBill({
  name: '객실 청소',
  price: 30
});

function displayBill(bill) {
  return `이름: ${bill.name} 비용: ${bill.total}`;
}