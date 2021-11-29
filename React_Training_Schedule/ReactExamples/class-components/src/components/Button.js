import React, { Component } from "react";

export default class Button extends Component {
  render() {
    return (
      <div>
        <button
          style={{
            color: "white",
            backgroundColor: "black",
            padding: "6px",
            borderRadius: "10px",
          }}
          onClick={() => {
            alert("yoo View More!!");
          }}
        >
          View More
        </button>
      </div>
    );
  }
}
