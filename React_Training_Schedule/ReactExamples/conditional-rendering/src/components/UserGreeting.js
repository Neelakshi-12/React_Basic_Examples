import React, { Component } from "react";

export default class UserGreeting extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: false,
    };
  }

  render() {
    if (this.state.isLoggedIn) {
      return (
        <div>
          <h2>Hello Neelakshi</h2>
        </div>
      );
    } else {
      return (
        <div>
          <div>
            <h2>Hello Everyone</h2>
          </div>
        </div>
      );
    }
  }
}
