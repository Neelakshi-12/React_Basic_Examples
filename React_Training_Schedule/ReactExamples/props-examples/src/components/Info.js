import React from "react";

export default function Info(props) {
  return (
    <div>
      <h1>
        Name : <b style={{ color: "red" }}>{props.name}</b>
      </h1>
      {props.children}
      <h3 style={{ color: "green" }}>{props.job}</h3>
    </div>
  );
}
