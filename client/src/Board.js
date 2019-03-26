import React, { Component } from 'react';
import './App.css';

class Board extends Component {

    constructor() {
        super();
        this.state = {
            selectedProjectName: null,
            todo: [],
            doing: [],
            done: [],
        }
    }

    async componentWillReceiveProps(nextProps) {
        let projectResponse = await fetch('/api/projects/' + nextProps.projectId);
        let selectedProject = await projectResponse.json();
        let tasksResponse = await fetch('/api/projects/' + nextProps.projectId + '/tasks');
        let tasks = await tasksResponse.json();
        let newState = this.state;
        newState.selectedProjectName = selectedProject.name;
        newState.todo = tasks.filter(t => t.taskStatus === 1);
        newState.doing = tasks.filter(t => t.taskStatus === 2);
        newState.done = tasks.filter(t => t.taskStatus === 3);
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