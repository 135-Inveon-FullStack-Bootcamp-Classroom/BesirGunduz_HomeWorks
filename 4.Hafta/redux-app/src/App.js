import "./App.css";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import React from "react";

//page
import Home from "./pages/Home";

function App() {
  return (
    <Router>
      <div>
        <Switch>
          <Route path="/" component={Home}></Route>
        </Switch>
      </div>
    </Router>
  );
}

export default App;
