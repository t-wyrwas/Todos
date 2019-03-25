import React, { Component } from 'react';
import './App.css';

class Board extends Component {

    constructor() {
        super();
        this.state = {
            selectedProjectName: null,
            todo: [
                {
                    name: "do shoping",
                    details: "buy some bread"
                },
                {
                    name: "go to school",
                    details: "learn something finally"
                }
            ],
            doing: [
                {
                    name: "read a book",
                    details: "be smarter"
                },
            ],
            done: [
                {
                    name: "by a car",
                    details: "hyundai i30"
                },
                {
                    name: "do something with your life",
                    details: "e.g. stop living in a cellar"
                },
            ],
        }
    }

    async componentWillReceiveProps(nextProps) {
        let newState = this.state;
        let response = await fetch('/api/projects/' + nextProps.projectId);
        let selectedProject = await response.json();
        newState.selectedProjectName = selectedProject.name;
        this.setState(newState);
    }

    render() {
        return (
            <div className="board">
                <h2>Project: {this.state.selectedProjectName}</h2>
                <div className="board-task-area">
                    <div className="status-column">
                        <div>
                            <h3>To do</h3>
                        </div>
                        {this.state.todo.map(function(task) {
                            return <div className="task">
                                    <div className="task-name">
                                        {task.name}
                                    </div>
                                    <div className="task-details">
                                        {task.details}
                                    </div>
                                </div>
                        })}
                    </div>
                    <div className="status-column">
                        <div>
                            <h3>Doing</h3>
                        </div>
                        {this.state.doing.map(function(task) {
                            return <div className="task">
                                    <div className="task-name">
                                        {task.name}
                                    </div>
                                    <div className="task-details">
                                        {task.details}
                                    </div>
                                </div>
                        })}
                    </div>
                    <div className="status-column">
                        <div>
                            <h3>Done</h3>
                        </div>
                        {this.state.done.map(function(task) {
                            return <div className="task">
                                    <div className="task-name">
                                        {task.name}
                                    </div>
                                    <div className="task-details">
                                        {task.details}
                                    </div>
                                </div>
                        })}
                    </div>
                </div>
            </div>
        );
    }
}

export default Board;