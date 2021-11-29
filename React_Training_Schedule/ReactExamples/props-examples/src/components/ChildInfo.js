import React from "react";

function ChildInfo(props) {
  return (
    <div>
      <button onClick={props.greetHandler}>Child Info</button>
    </div>
  );
}

export default ChildInfo;
