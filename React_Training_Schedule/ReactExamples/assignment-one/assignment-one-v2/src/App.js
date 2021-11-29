import React, { useState } from "react";

const App = () => {
  const [data, setData] = useState({
    username: "",
    password: "",
  });

  const { username, password } = data;
  const changeHandler = (e) => {
    setData({ ...data, [e.target.name]: [e.target.value] });
  };
  const submitHandler = (e) => {
    e.preventDefault();
    console.log(data);
  };
  return (
    <div>
      <h3>Hello World</h3>

      <form onSubmit={submitHandler}>
        <input
          type="text"
          onChange={changeHandler}
          name="username"
          value={username}
        />
        <br />
        <input
          type="password"
          onChange={changeHandler}
          name="password"
          value={password}
        />
        <br />
        <input type="submit" name="submit" />
      </form>
    </div>
  );
};

export default App;
