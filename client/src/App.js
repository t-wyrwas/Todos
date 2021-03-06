import React, { Component } from 'react';
import './App.css';
import Menu from './Menu.js'
import Board from './Board.js'

class App extends Component {

  constructor() {
    super();
    this.state = {selectedProject: 'None'};
    this.selectProject = this.selectProject.bind(this);
  }

  render() {
    return (
      <div className="App">
        <Menu selectProject={this.selectProject}></Menu>
        <Board projectId={this.state.selectedProject}></Board>
      </div>
    );
  }

  selectProject(id) {
        let newState = this.state;
        newState.selectedProject = id;
        this.setState(newState);
  }
}

export default App;