import React, { Component } from "react";

export default class EventBind extends Component {
  constructor(props) {
    super(props);

    this.state = {
      message: "hELLO Everyone!!",
    };
  }

  clickHandler() {
    this.setState({
      message: "First Click : bYE eVERYoNE!!",
    });
  }
  clickHandler2() {
    this.setState({
      message: " Second Click : bYE eVERYoNE!!",
    });
  }

  render() {
    return (
      <div>
        <h2>{this.state.message}</h2>
        <button onClick={this.clickHandler.bind(this)}>Click</button>
        <button onClick={() => this.clickHandler2()}>Click Second Time</button>
      </div>
    );
  }
}
