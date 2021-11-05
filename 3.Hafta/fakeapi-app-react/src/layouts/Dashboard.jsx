import React from "react";
import { Grid } from "semantic-ui-react";
import Users from "./Users";
import UserList from "../pages/userList";

function Dashboard() {
  return (
    <div>
      <Grid>
        <Grid.Row>
          <Grid.Column width={4}>
            <h1>Müşteriler</h1>
            <Users />
          </Grid.Column>
          <Grid.Column width={12}>
            <h1>Müşteri Bilgileri</h1>
            <UserList />
          </Grid.Column>
        </Grid.Row>
      </Grid>
    </div>
  );
}

export default Dashboard;
