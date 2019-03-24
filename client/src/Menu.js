import React, { Component } from 'react';
import './App.css';
import ProjectSelection from './ProjectSelection';

class Menu extends Component {

    constructor() {
        super();
        this.state = {
            projects: {
                name: 'None',
                select: this.props.selectProject
            }
        }
    }
    
    componentWillMount() {
        this.setState({projects: ['proj1', 'proj2']})
    }

    render() {
        return (
            <div className="menu">
                {this.state.projects.map(function (project) {
                    return <ProjectSelection name={project.name} selectProject={project.select}></ProjectSelection>
                })} 
            </div>
        );
    }
}

export default Menu;
