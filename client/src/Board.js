import React, { Component } from 'react';
import './App.css';

class Board extends Component {

    constructor() {
        super();
    }
    
    componentWillMount() {
    }

    render() {
        return (
            <div className="board">
                <span>Project: {this.props.projectName}</span>
            </div>
        );
    }
}

export default Board;