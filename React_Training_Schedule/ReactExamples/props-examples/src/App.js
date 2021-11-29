import logo from "./logo.svg";
import "./App.css";
import Info from "./components/Info";
import Button from "./components/Button";
import ParentInfo from "./components/ParentInfo";

function App() {
  return (
    <div className="App">
      <Info name="Neelakshi T" job="Software Developer">
        <p>I am from Uttar Pradesh.</p>
      </Info>
      <Info name="Shreya Saxena" job="Automation Testing" />
      <Info name="Rochna Trivedi" job="Network Security" />
      <Button title="View More" />
      <Button title="Brief More" />
      <Button title="Learn More" />

      <h3>************************</h3>
      <ParentInfo />
    </div>
  );
}

export default App;
