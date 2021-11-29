import React, { Component } from "react";

export default class UserGreetingThree extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: false,
    };
  }

  render() {
    return this.state.isLoggedIn && <div>Welcome Neelakshi T</div>;
  }
}
