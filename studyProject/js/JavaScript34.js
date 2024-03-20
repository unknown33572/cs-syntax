const landscapes = [
  {
  title: 'Landscape',
  photographer: 'Nathan',
  equipment: 'Canon',
  format: 'digital',
  src: '/landscape-nm.jpg',
  location: [32.7122222, -103.1405556],
  },
  {
    title: 'Landscape',
    photographer: '',
    equipment: 'Nikon',
    format: 'film',
    src: 'landscape-ms.jpg',
    location: [32.3541667, -89.3988889],
  }
];

function displayPhoto(photo) {
  const title = photo.title;
  const photographer = photo.photographer || 'Anonymous';
  const location = photo.location;
  const url = photo.src;
  const copy = { ...photo };

  delete copy.title;
  delete copy.photographer;
  delete copy.location;
  delete copy.src;

  const additional = Object.keys(copy).map(key => `${key}: ${copy[key]}`);

  return (`
  <img alt="${title} photographed by ${photographer}" src="${url}" />
    <div>${title}</div>
    <div>Photographed by ${photographer}</div>
    <div>Latitude: ${location[0]}</div>
    <div>Longitude: ${location[1]}</div>
    <div>${additional.join(' <br/> ')}</div>
  `)
}

//console.log(displayPhoto(landscapes[0]));
//console.log(displayPhoto(landscapes[1]));

//const { photographer } = landscapes[0];
//const { title: subject, photographer: author } = landscapes[1]; // 변수명 변경

//console.log(photographer);
//console.log(subject);
//console.log(author);

const {
  photographer,
  ...additional
} = landscapes[0];

console.log(photographer);
console.log(additional);