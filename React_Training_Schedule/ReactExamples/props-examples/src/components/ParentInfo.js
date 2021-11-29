import React, { Component } from "react";
import ChildInfo from "./ChildInfo";

export default class ParentInfo extends Component {
  constructor(props) {
    super(props);

    this.state = {
      parentName: "Parent Name",
    };
    this.greetParent = this.greetParent.bind(this);
  }

  greetParent() {
    alert(`Heloooo ${this.state.parentName}`);
    console.log("yoooo");
  }

  render() {
    return (
      <div>
        <ChildInfo greetHandler={this.greetParent} />
      </div>
    );
  }
}
