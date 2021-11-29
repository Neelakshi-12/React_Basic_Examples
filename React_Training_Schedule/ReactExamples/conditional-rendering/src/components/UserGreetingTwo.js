import React, { Component } from "react";

export default class UserGreetingTwo extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: false,
    };
  }

  render() {
    return this.state.isLoggedIn ? (
      <div>Welcome Neelu..</div>
    ) : (
      <div>Welcome Neelakshi</div>
    );
  }
}
