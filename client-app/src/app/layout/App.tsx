import React, { useState, useEffect, Fragment } from "react";
import { Container } from 'semantic-ui-react'
import "./styles.css";
import axios from 'axios'
import { IActivity } from './../../models/activity';
import { NavBar } from './../../features/nav/NavBar';
import ActivityDashboard from "../../features/nav/activities/dashboard/ActivityDashboard";

const App = () => {
    const [activities, setActivities] = useState<IActivity[]>([]);
    const [selectedActivity, setSelectedActivity] = useState<IActivity | null>(null);

    // This handler takes an id and selects the activity from the list of activity
    const handleSelectActivity = (id: string) => {
        setSelectedActivity(activities.filter(a => a.id === id)[0])
    }

    useEffect(() => {
        axios.get<IActivity[]>("http://localhost:5000/api/activities")
            .then((response) => {
                setActivities(response.data)
            })
    }, []);

    return (
        <Fragment>
            <NavBar />
                <Container style={{marginTop: "7em"}}>
                    {/* pass activities as a prop to the ActivityDashboard */}
                    <ActivityDashboard activities={activities} selectActivity={handleSelectActivity} selectedActivity={selectedActivity} />
                </Container>
        </Fragment>
    );

}

export default App;
