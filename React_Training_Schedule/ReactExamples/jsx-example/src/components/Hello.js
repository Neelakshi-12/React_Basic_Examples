// import React, { Component } from "react";

// with JSX
// export default class Hello extends Component {
//   render() {
//     return (
//       <div>
//         <h1>YO 🤗 Neelakshi!!</h1>
//       </div>
//     );
//   }
// }

//with out JSX
import React from "react";

const Hello = () => {
  return React.createElement(
    "div",
    { id: "firstid", className: "firstClassName" },
    React.createElement("h1", null, "Helloo Neelakshi!!")
  );
};
export default Hello;
