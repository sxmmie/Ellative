import React from 'react'
import { Card, Button, Image } from 'semantic-ui-react'
import { IActivity } from '../../../../models/activity'

interface IProps {
    activity: IActivity;
}

export const ActivityDetail: React.FC<IProps> = ({activity}) => {
    return (
        <Card fluid>
            <Image src={`/assets/categoryImages/${activity.category}.jpg`} wrapped ui={false} />
            <Card.Content>
                <Card.Header>{activity.title}</Card.Header>
                <Card.Meta>
                    <span>{activity.date}</span>
                </Card.Meta>
                <Card.Description>
                    {activity.description}
                </Card.Description>
            </Card.Content>
            <Card.Content extra>
                <Button.Group widths={2}>
                    <Button basic color="blue" content="Edit" />
                    <Button basic color="grey" content="Cancel" />
                </Button.Group>
            </Card.Content>
        </Card>
    )
}
