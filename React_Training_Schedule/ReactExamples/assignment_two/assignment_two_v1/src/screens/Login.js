import { Button } from "@material-ui/core";
import React, { Component } from "react";

export default class Login extends Component {
  constructor() {
    super();
    this.state = {
      name: "",
      password: "",
    };
  }
  login() {
    console.warn(this.state);

    fetch("http://localhost:5000/login?q=" + this.state.name).then((data) => {
      data.json().then((resp) => {
        console.log("resp", resp);
        if (resp.length > 0) {
          console.warn(this.props.history.push("home"));
        } else {
          alert("Please Check UserName and Password");
        }
      });
    });
  }
  render() {
    return (
      <div>
        <h1
          style={{
            color: "#006d77",
            marginBottom: "20px",
            marginTop: "150px",
            fontFamily: "monospace",
            fontWeight: "bold",
          }}
        >
          LOGIN FORM
        </h1>

        <div className="container">
          <div
            class="card"
            style={{ marginLeft: "300px", marginRight: "300px" }}
          >
            <div
              class="card-body"
              style={{ backgroundColor: "#edf6f9", padding: "50px" }}
            >
              <div className="input-group mb-3">
                <input
                  className="form-control"
                  name="user"
                  type="text"
                  placeholder="Enter Name"
                  aria-label="Username"
                  required
                  aria-describedby="basic-addon1"
                  onChange={(event) =>
                    this.setState({ name: event.target.value })
                  }
                />
              </div>
              <div className="input-group mb-3">
                <input
                  className="form-control"
                  name="password"
                  required
                  type="password"
                  placeholder="Enter Password"
                  aria-label="Password"
                  aria-describedby="basic-addon1"
                  onChange={(event) =>
                    this.setState({ password: event.target.value })
                  }
                />
              </div>

              {this.state.name && this.state.password ? (
                <button
                  type="button"
                  onClick={() => {
                    this.login();
                  }}
                  class="btn btn-success"
                  style={{ width: "100%" }}
                >
                  {" "}
                  LOGIN
                </button>
              ) : (
                <button
                  type="button"
                  class="btn btn-warning"
                  style={{ width: "100%" }}
                  data-bs-toggle="tooltip"
                  data-bs-placement="top"
                  title="Warning Message : Enter all Fields"
                >
                  Enter Details
                </button>
              )}
            </div>
          </div>
        </div>
      </div>
    );
  }
}
