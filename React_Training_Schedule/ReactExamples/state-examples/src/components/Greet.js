import React from "react";

const Greet = ({ name, job }) => {
  console.log("Props", name, job);
  return (
    <div>
      <h1>
        Helloo {name} . <br />
        Designation {job}
      </h1>
    </div>
  );
};

export default Greet;
