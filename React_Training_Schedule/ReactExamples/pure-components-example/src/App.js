import React, { Component } from "react";
import "./App.css";
import FocusInput from "./components/FocusInput";
import FRParentInput from "./components/FRParentInput";
import ParentComp from "./components/ParentComp";
import PureComp from "./components/PureComp";
import RefsDemo from "./components/RefsDemo";
class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <ParentComp />
          <h3> *************** Refs Demo ***************** </h3>
          <RefsDemo />
          <h3> *************** FocusInput Demo ***************** </h3>
          <FocusInput />
          <h3> *************** FR FocusInput Demo ***************** </h3>
          <FRParentInput />
        </header>
      </div>
    );
  }
}

export default App;
