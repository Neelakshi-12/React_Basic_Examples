import React from "react";

function MemoComp({ name }) {
  console.log("Rendering Memo Comp");
  return (
    <div>
      {" "}
      <h3> Memo Component {name} </h3>
    </div>
  );
}
export default React.memo(MemoComp);
