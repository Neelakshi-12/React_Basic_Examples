import React, { useState } from "react";
import { makeStyles } from "@material-ui/core/styles";
import TextField from "@material-ui/core/TextField";
import Button from "@material-ui/core/Button";
import { useHistory } from "react-router";
import { useDispatch } from "react-redux";
import { addUser } from "./redux/actions";
const useStyles = makeStyles((theme) => ({
  root: {
    marginTop: 100,
    "& > *": {
      margin: theme.spacing(1),
      width: "45ch",
    },
  },
}));

const AddUser = () => {
  const classes = useStyles();
  const [state, setState] = useState({
    name: "",
    email: "",
    contact: "",
    address: "",
  });

  const [error, setError] = useState("");

  let history = useHistory();
  let dispatch = useDispatch();
  const { name, email, contact, address } = state;

  const handleInputChange = (e) => {
    let { name, value } = e.target;
    setState({ ...state, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!name || !email || !contact || !address) {
      setError("Please input all input Field");
    } else {
      dispatch(addUser(state));
      history.push("/home");
      setError("");
    }
  };

  return (
    <div>
      <Button
        style={{ width: "100px", marginTop: "20px" }}
        variant="contained"
        color="primary"
        type="submit"
        size="small"
        onClick={() => history.push("/home")}
      >
        Go Back
      </Button>
      <h1>Add User</h1>
      {error && <h3 style={{ color: "red" }}>{error}</h3>}

      <form
        className={classes.root}
        noValidate
        autoComplete="off"
        onSubmit={handleSubmit}
      >
        <TextField
          id="filled-basic"
          label="Enter Name"
          variant="filled"
          value={name}
          name="name"
          type="text"
          onChange={handleInputChange}
        />
        <br />
        <TextField
          id="filled-basic"
          label="Email Id"
          variant="filled"
          value={email}
          name="email"
          type="email"
          onChange={handleInputChange}
        />
        <br />
        <TextField
          id="filled-basic"
          label="Contact Details"
          variant="filled"
          value={contact}
          name="contact"
          type="number"
          onChange={handleInputChange}
        />
        <br />
        <TextField
          id="filled-basic"
          label="Address"
          variant="filled"
          value={address}
          name="address"
          type="text"
          onChange={handleInputChange}
        />
        <br />
        <Button
          style={{ width: "100px" }}
          variant="contained"
          color="secondary"
          type="submit"
        >
          Submit
        </Button>
      </form>
    </div>
  );
};

export default AddUser;
