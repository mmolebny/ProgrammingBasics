const iterate = (object, callback) => {
  const keys = Object.keys(object);
  for (const key of keys) {
    callback(key, object[key], object);
  }
};

const store = (value) => () => value;

const contract = (fn, ...types) => (...args) => {
  for (let i = 0; i < args.length; i++) {
    const name = types[i].name.toLowerCase();
    if (typeof args[i] !== name) {
      throw new TypeError(`Argument type mismatch`);
    }
  }
  const result = fn(...args);
  const name = types[types.length - 1].name.toLowerCase();
  if (typeof result !== name) {
    throw new TypeError(`Result type mismatch`);
  }
  return result;
};

module.exports = { iterate, store, contract };
