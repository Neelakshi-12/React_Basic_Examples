import React, { Component } from "react";

export default class ClassClick extends Component {
  clickHandler() {
    console.log("Clicked Button");
  }
  render() {
    return (
      <div>
        <button onClick={this.clickHandler}>Click Me : Class</button>
      </div>
    );
  }
}
