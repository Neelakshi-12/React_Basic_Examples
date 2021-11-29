import React, { Component, PureComponent } from "react";
import MemoComp from "./MemoComp";
import PureComp from "./PureComp";
import RegComp from "./RegComp";

export default class ParentComp extends PureComponent {
  constructor(props) {
    super(props);

    this.state = {
      name: "Neelakshi",
    };
  }

  componentDidMount() {
    setInterval(() => {
      this.setState({
        name: "Neelakshii",
      });
    }, 2000);
  }
  render() {
    console.log(
      "**********************Parent Component render ****************************"
    );
    return (
      <div>
        <h3>Parent Component</h3>
        <MemoComp name={this.state.name} />
        <RegComp name={this.state.name} />
        <PureComp name={this.state.name} />
      </div>
    );
  }
}
