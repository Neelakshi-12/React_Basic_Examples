import React, { Component } from "react";

export default class Info extends Component {
  constructor() {
    super();
    this.state = {
      name: "Welcome Neelakshi!",
    };
  }
  viewMessage() {
    this.setState({
      name: "Thanks For Clicking!!",
    });
  }
  render() {
    return (
      <div>
        <h1>{this.state.name}</h1>
        <button onClick={() => this.viewMessage()}>Click Me</button>
      </div>
    );
  }
}
