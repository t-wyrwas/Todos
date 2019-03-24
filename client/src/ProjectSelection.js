import React, { Component } from 'react';
import './App.css';

class ProjectSelection extends Component {

    constructor() {
        super();
        this.selectSelf = this.selectSelf.bind(this);
    }
    
    componentWillMount() {
    }

    render() {
        return (
            <div className="project-selection">
                <div className="project-name" onClick={this.selectSelf}>{this.props.name}</div>
            </div>
        );
    }

    selectSelf() {
        this.props.selectProject(this.props.id);
    }
}

export default ProjectSelection;
