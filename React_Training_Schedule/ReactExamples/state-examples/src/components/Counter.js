import React, { Component } from "react";

export default class Counter extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }
  likeFunction() {
    this.setState(
      {
        count: this.state.count + 1,
      },
      () => {
        console.log("Callback Value", this.state.count);
      }
    );
    console.log(this.state.count);
  }
  render() {
    return (
      <div>
        <h2> Count - {this.state.count}</h2>
        <button onClick={() => this.likeFunction()}>Like 👍</button>
      </div>
    );
  }
}
