import React, { Component } from "react";

export default class RegComp extends Component {
  render() {
    console.log("Reg Component Render");
    return (
      <div>
        <h3>Regular Components {this.props.name}</h3>
      </div>
    );
  }
}
