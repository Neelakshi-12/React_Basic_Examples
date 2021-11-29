import logo from "./logo.svg";
import "./App.css";
import FunctionClick from "./components/FunctionClick";
import ClassClick from "./components/ClassClick";
import EventBind from "./components/EventBind";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <FunctionClick />
        <ClassClick />
        <h3>*********************</h3>
        <EventBind />
      </header>
    </div>
  );
}

export default App;
