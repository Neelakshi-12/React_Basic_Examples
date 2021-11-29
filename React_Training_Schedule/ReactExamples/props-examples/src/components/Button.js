import React, { Component } from "react";

export default class Button extends Component {
  render() {
    return (
      <div>
        {/* class component props */}
        <button
          style={{
            backgroundColor: "black",
            color: "white",
            padding: "6px",
            borderRadius: "10px",
            width: "100px",
            height: "30px",
          }}
        >
          {this.props.title}
        </button>
      </div>
    );
  }
}
