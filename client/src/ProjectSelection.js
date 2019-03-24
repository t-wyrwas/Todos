import React, { Component } from 'react';
import './App.css';

class ProjectSelection extends Component {

    constructor() {
        super();
    }
    
    componentWillMount() {
    }

    render() {
        return (
            <div className="project-selection">
                <div onKeyPress={this.selectSelf}>{this.props.name}</div>
            </div>
        );
    }

    selectSelf() {
        this.props.selectProject(this.props.name);
    }
}

export default ProjectSelection;
