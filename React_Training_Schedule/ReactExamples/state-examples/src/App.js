import logo from "./logo.svg";
import "./App.css";
import Info from "./components/Info";
import Counter from "./components/Counter";
import Greet from "./components/Greet";
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Info />
        <Counter />
        <h3>*********************</h3>
        <Greet name="Neelakshi  T" job="Software Developer" />
      </header>
    </div>
  );
}

export default App;
