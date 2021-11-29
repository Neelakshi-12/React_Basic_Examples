import React, { useState } from "react";
import { Form } from "react-bootstrap";
import { Link } from "react-router-dom";

const UserForm = (props) => {
  const [state, setState] = useState({
    username: "",
    email: "",
    city: "",
    phone: "",
  });

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setState((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  return (
    <div>
      <h1 style={{ color: "green", textAlign: "center" }}>Simple Form</h1>
      <div className="container">
        <div className="card">
          <div className="card-body">
            <Form className="register-form">
              <Form.Group controlId="username">
                <Form.Label>Name</Form.Label>
                <Form.Control
                  type="text"
                  placeholder="Enter username"
                  name="username"
                  onChange={handleInputChange}
                />
              </Form.Group>
              <Form.Group controlId="email">
                <Form.Label>Email</Form.Label>
                <Form.Control
                  type="email"
                  placeholder="Enter email"
                  name="email"
                  onChange={handleInputChange}
                />
              </Form.Group>
              <Form.Group controlId="city">
                <Form.Label>Message</Form.Label>
                <Form.Control
                  as="textarea"
                  placeholder="Enter Message"
                  name="city"
                  onChange={handleInputChange}
                />
              </Form.Group>
              <Form.Group controlId="phone">
                <Form.Label>Phone</Form.Label>
                <Form.Control
                  type="text"
                  placeholder="Enter phone"
                  name="phone"
                  onChange={handleInputChange}
                />
              </Form.Group>

              <Link
                className="btn btn-success"
                to={{
                  pathname: "/details",
                  state,
                }}
              >
                Submit
              </Link>
            </Form>
          </div>
        </div>
      </div>
    </div>
  );
};

export default UserForm;
