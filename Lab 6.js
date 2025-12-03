const pipe = (...fns) => {
  for (const fn of fns) {
    if (typeof fn !== 'function') {
      throw new Error('All arguments must be functions');
    }
  }
  return x => fns.reduce((v, f) => f(v), x);
};

const composeRight = (...fns) => {
  const listeners = {};
  
  const composition = (initialValue) => {
    let result = initialValue;
    for (let i = fns.length - 1; i >= 0; i--) {
      try {
        result = fns[i](result);
      } catch (e) {
        if (listeners.error) {
          listeners.error.forEach(fn => fn(e));
        }
        return undefined;
      }
    }
    return result;
  };

  composition.on = (event, callback) => {
    if (!listeners[event]) {
      listeners[event] = [];
    }
    listeners[event].push(callback);
  };

  return composition;
};
