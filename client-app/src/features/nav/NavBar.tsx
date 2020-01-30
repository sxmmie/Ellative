import React from 'react'
import { Menu, Button, Container } from 'semantic-ui-react'

export const NavBar = () => {
    return (
        <Menu fixed="top" inverted>
            <Container>
                <Menu.Item>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: '10px'}}/>
                    Ellative
                </Menu.Item>
                <Menu.Item name='Activities' />
                <Menu.Item>
                    <Button positive content="Create Activity" />
                </Menu.Item>
            </Container>
        </Menu>
    )
}
