import React, { Component } from "react";

class LifeCycleB extends Component {
  constructor(props) {
    super(props);

    this.state = {
      name: "Neelakshi",
    };
    console.log("LifeCycleB constructor");
  }

  static getDerivedStateFromProps(props, state) {
    console.log("LifeCycleB getDerivedStateFromProps");
    return null;
  }

  componentDidMount() {
    console.log("LifeCycleB componentDidMount");
  }
  shouldComponentUpdate() {
    console.log("LifeCycleB shouldComponentUpdate");
    return true;
  }

  getSnapshotBeforeUpdate(prevProps, prevState) {
    console.log(" LifeCycleB getSnapshotBeforeUpdate");
  }

  componentDidUpdate() {
    console.log(" LifeCycleB componentDidUpdate");
  }

  render() {
    console.log("ifecycleA render");
    return <div>LifeCycleB</div>;
  }
}

export default LifeCycleB;
