const seq = (...fns) => (val) => {
  if (typeof val === 'number') {
    let result = val;
    for (let i = fns.length - 1; i >= 0; i--) {
      result = fns[i](result);
    }
    return result;
  }
  return seq(...fns, val);
};

const array = () => {
  const data = [];
  const get = (i) => data[i];
  get.push = (x) => data.push(x);
  get.pop = () => data.pop();
  return get;
};

module.exports = { seq, array };
