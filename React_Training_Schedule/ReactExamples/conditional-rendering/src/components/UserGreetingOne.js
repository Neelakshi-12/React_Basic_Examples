import React, { Component } from "react";

export default class UserGreetingOne extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: true,
    };
  }

  render() {
    let message;
    if (this.state.isLoggedIn) {
      message = <div>Welcome Neelu..</div>;
    } else {
      message = <div>Welcome Neelakshi..</div>;
    }
    return <div>{message}</div>;
  }
}
