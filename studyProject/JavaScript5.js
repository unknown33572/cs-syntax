fetch('https://jsonplaceholder.typicode.com/posts/1', {
  method: 'PUT',
  body: JSON.stringify({
    id: 1,
    title: 'foo',
  }),
  header: {
    'content-type': 'application/json;
  },

}).then((response) => response.json());