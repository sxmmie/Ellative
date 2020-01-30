import React from 'react'
import { Grid, List } from 'semantic-ui-react'
import { IActivity } from './../../../../models/activity';
import { ActivityList } from './ActivityList';
import { ActivityDetail } from '../details/ActivityDetail';
import { ActivityForm } from '../form/ActivityForm';

interface IProps {
    activities: IActivity[];
    selectActivity: (id: string) => void;
    selectedActivity: IActivity | null;
}

export const ActivityDashboard : React.FC<IProps> = ({activities, selectActivity, selectedActivity}) => {
    return (
        <Grid>
            <Grid.Column width={10}s>
                <ActivityList activities={activities} selectActivity={selectActivity} />
            </Grid.Column>
            <Grid.Column width={6}>
                {selectedActivity && <ActivityDetail activity={selectedActivity} />}
                <ActivityForm />
            </Grid.Column>
        </Grid>
    )
}

export default ActivityDashboard