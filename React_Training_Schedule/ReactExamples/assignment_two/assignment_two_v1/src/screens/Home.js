import React, { useEffect } from "react";
import { withStyles, makeStyles } from "@material-ui/core/styles";
import Table from "@material-ui/core/Table";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableContainer from "@material-ui/core/TableContainer";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Paper from "@material-ui/core/Paper";
import { deleteUser, loadUsers } from "./redux/actions";
import Button from "@material-ui/core/Button";
import ButtonGroup from "@material-ui/core/ButtonGroup";
import { useHistory } from "react-router-dom";
import Icon from "@material-ui/core/Icon";

import { useDispatch, useSelector } from "react-redux";
const StyledTableCell = withStyles((theme) => ({
  head: {
    backgroundColor: "#006d77",
    color: theme.palette.common.white,
  },
  body: {
    fontSize: 14,
    fontWeight: "bold",
  },
}))(TableCell);

const StyledTableRow = withStyles((theme) => ({
  root: {
    "&:nth-of-type(odd)": {
      backgroundColor: theme.palette.action.hover,
    },
  },
}))(TableRow);

const useStyles = makeStyles({
  table: {
    marginTop: 50,
    minWidth: 700,
  },
});
const useButtonStyles = makeStyles((theme) => ({
  root: {
    display: "flex",
    flexDirection: "column",
    alignItems: "center",
    "& > *": {
      margin: theme.spacing(1),
    },
  },
}));

const Home = () => {
  const classes = useStyles();

  const buttonStyles = useButtonStyles();
  let dispatch = useDispatch();
  let history = useHistory();
  const { users } = useSelector((state) => state.data);
  useEffect(() => {
    dispatch(loadUsers());
  }, []);

  const handleDelete = (id) => {
    console.log("handle Delete");
    if (window.confirm("Are you sure wanted to Delete the User ? ")) {
      dispatch(deleteUser(id));
    }
  };

  return (
    <div>
      <h2
        style={{
          marginTop: "30px",
          color: "green",
          fontFamily: "monospace",
          fontWeight: "bold",
        }}
      >
        Employee Details Page
      </h2>

      <div className={buttonStyles.root}></div>

      <div style={{ marginLeft: "200px", marginRight: "200px" }}>
        <div class="d-flex flex-row">
          <div class="p-2">
            {" "}
            <button
              className="btn btn-success"
              onClick={() => history.push("/addUser")}
            >
              Add Employee{" "}
              <Icon style={{ marginBottom: "-5px" }}>add_circle</Icon>
            </button>
          </div>
        </div>

        <TableContainer component={Paper}>
          <Table
            style={{ backgroundColor: "#edf6f9" }}
            aria-label="customized table"
          >
            <TableHead>
              <TableRow>
                <StyledTableCell>Name </StyledTableCell>
                <StyledTableCell align="center">Email</StyledTableCell>
                <StyledTableCell align="center">Contact</StyledTableCell>
                <StyledTableCell align="center">Address</StyledTableCell>
                <StyledTableCell align="center">Action</StyledTableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {users.map((user) => (
                <StyledTableRow key={user.id}>
                  <StyledTableCell component="th" scope="row">
                    {user.name}
                  </StyledTableCell>
                  <StyledTableCell align="center">{user.email}</StyledTableCell>
                  <StyledTableCell align="center">
                    {user.contact}
                  </StyledTableCell>
                  <StyledTableCell align="center">
                    {user.address}
                  </StyledTableCell>
                  <StyledTableCell align="center">
                    <div className={buttonStyles.root}>
                      <ButtonGroup
                        size="small"
                        variant="contained"
                        aria-label="contained primary button group"
                      >
                        <button
                          style={{ marginRight: "5px" }}
                          className="btn btn-warning"
                          color="primary"
                          onClick={() => history.push(`/editUser/${user.id}`)}
                        >
                          Edit{" "}
                          <Icon style={{ marginBottom: "-4px" }}>edit</Icon>
                        </button>
                        <button
                          className="btn btn-danger"
                          onClick={() => handleDelete(user.id)}
                        >
                          Delete{" "}
                          <Icon style={{ marginBottom: "-4px" }}>delete</Icon>
                        </button>
                      </ButtonGroup>
                    </div>
                  </StyledTableCell>
                </StyledTableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
        <div class="d-flex flex-row">
          <div class="p-2">
            {" "}
            <button
              style={{ marginTop: "20px" }}
              className="btn btn-dark"
              type="submit"
              size="small"
              onClick={() => history.push("/")}
            >
              Go Back <Icon style={{ marginBottom: "-7px" }}>chevron_left</Icon>
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Home;
