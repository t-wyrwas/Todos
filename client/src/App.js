import React, { Component } from 'react';
import './App.css';
import Menu from './Menu.js'

class App extends Component {

  constructor() {
    super();
    this.setState({selectedProject: null})
  }

  render() {
    return (
      <div className="App">
        <Menu selectProject={this.selectProject}></Menu>
      </div>
    );
  }

  selectProject(name) {
        let newState = this.state;
        newState.selectedProject = name;
        this.setState(newState);
  }
}

export default App;
