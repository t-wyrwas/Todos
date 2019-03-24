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
    
    async componentWillMount() {
        let response = await fetch('/api/projects');
        let projectList = await response.json()
        
        this.setState({
            projects: projectList.map((p) => {
                p.select = this.selectProject;
                return p;
            })
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
