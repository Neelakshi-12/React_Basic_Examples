import React from "react";
import { NavLink } from "react-router-dom";

const Details = (props) => {
  const { username, email, city, phone } =
    (props.location && props.location.state) || {};
  return (
    <div>
      <NavLink to="/" className="btn btn-danger">
        Go Back
      </NavLink>
      <div className="card" style={{ marginTop: "10px" }}>
        <div className="card-body">
          <div className="form-details">
            <div>
              <strong>Name:</strong> {username}
            </div>
            <div>
              <strong>Email:</strong> {email}
            </div>
            <div>
              <strong>Message:</strong> {city}
            </div>
            <div>
              <strong>Phone:</strong> {phone}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Details;
