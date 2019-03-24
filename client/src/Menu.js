import React, { Component } from 'react';
import './App.css';
import ProjectSelection from './ProjectSelection';

class Menu extends Component {

    constructor() {
        super();
        this.state = {
            projects: []
        }
        this.selectProject = this.selectProject.bind(this);
    }
    
    componentWillMount() {
        this.setState({
            projects: [
                {
                    id: 0,
                    name: 'Home',
                    select: this.selectProject
                },
                {
                    id: 1,
                    name: 'Work',
                    select: this.selectProject
                },
                {
                    id: 2,
                    name: 'Education',
                    select: this.selectProject
                }

            ]
        });
    }

    render() {
        return (
            <div className="menu">
                {this.state.projects.map(function (project) {
                    return <ProjectSelection id = {project.id} name={project.name} selectProject={project.select}></ProjectSelection>
                })} 
            </div>
        );
    }

    selectProject(id) {
        this.props.selectProject(id);
    }
}

export default Menu;
