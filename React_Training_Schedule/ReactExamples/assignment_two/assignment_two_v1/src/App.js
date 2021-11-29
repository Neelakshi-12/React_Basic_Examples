import logo from "./logo.svg";
import "./App.css";
import Home from "./screens/Home";
import { Switch, Route } from "react-router-dom";
import AddUser from "./screens/AddUser";
import EditUser from "./screens/EditUser";
import Login from "./screens/Login";
function App() {
  return (
    <div className="App">
      <Switch>
        <Route exact path="/home" component={Home} />
        <Route exact path="/" render={(props) => <Login {...props} />} />
        <Route exact path="/adduser" component={AddUser} />
        <Route exact path="/editUser/:id" component={EditUser} />
      </Switch>
    </div>
  );
}
export default App;
