import logo from "./logo.svg";
import "./App.css";
import UserGreeting from "./components/UserGreeting";
import UserGreetingOne from "./components/UserGreetingOne";
import UserGreetingTwo from "./components/UserGreetingTwo";
import UserGreetingThree from "./components/UserGreetingThree";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <UserGreeting />
        <UserGreetingOne />
        <UserGreetingTwo />
        <UserGreetingThree />
      </header>
    </div>
  );
}

export default App;
