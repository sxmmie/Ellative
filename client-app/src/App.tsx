import React, { Component } from "react";
import { Header, Icon, List } from 'semantic-ui-react'
import "./App.css";
import axios from 'axios'

class App extends Component {
    state = {
        weathers: []
    };

    // Wait till the component gets mounted and go fetch some data from API
    // when we set state here, we trigger a re-render of our component and updated state is displayed on webpage
    componentDidMount() {
        axios.get("localhost:5000/api/weathers")
            .then((response) => {
                this.setState({
                    weathers: response.data
                });
            })
    }

    render() {
        return (
            <div>
                <Header as='h2' icon='plug' content='Uptime Guarantee'>
                    <Icon name="users"/>
                    <Header.Content>Ellative</Header.Content>
                </Header>
                <List>
                    {this.state.weathers.map((weather: any) => (
                        <List.Item key={weather.id}>{weather.type}</List.Item>
                    ))}
                </List>
            </div>
        );
    }
}

export default App;
