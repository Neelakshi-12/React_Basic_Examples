import React, { Component } from "react";

export default class Home extends Component {
  render() {
    return (
      <div className="container">
        <div className="row">
          <div class="col-6 col-md-2"></div>
          <div class="col-6 col-md-8">
            <h2
              style={{
                textAlign: "center",
                marginTop: "30px",
                marginBottom: "30px",
              }}
            >
              Explore YourSelf ..{" "}
            </h2>
            <div className="card">
              <div className="cardbody" style={{ padding: "20px" }}>
                <form>
                  <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label">
                      Enter Name
                    </label>
                    <input
                      type="text"
                      class="form-control"
                      id="exampleFormControlInput1"
                      placeholder="Neelakshi"
                    />
                  </div>
                  <div class="mb-3">
                    <label for="exampleFormControlTextarea1" class="form-label">
                      Tell me about your self
                    </label>
                    <textarea
                      class="form-control"
                      id="exampleFormControlTextarea1"
                      rows="3"
                    ></textarea>
                  </div>
                  <div className="d-flex justify-content-center">
                    <button
                      className="btn btn-success"
                      style={{ width: "20%" }}
                    >
                      Submit
                    </button>{" "}
                  </div>
                </form>
              </div>
            </div>
          </div>
          <div class="col-6 col-md-2"></div>
        </div>
      </div>
    );
  }
}
