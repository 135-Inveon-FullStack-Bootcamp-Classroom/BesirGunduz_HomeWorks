import { useState, useEffect } from "react";
import { Table, Icon, Menu } from "semantic-ui-react";
import UserService from "../services/UserService";

function UserList() {
  
  const [users, setUsers] = useState([]);

  useEffect(() => {
    let userService = new UserService();
    userService.getUsers().then((result) => setUsers(result.data));
  });

  return (
    <div>
      {/* sayfanın sağ tarafında müşteri bilgilerini listeledim */}
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>ID</Table.HeaderCell>
            <Table.HeaderCell>Adı Soyadı</Table.HeaderCell>
            <Table.HeaderCell>Kullanıcı Adı</Table.HeaderCell>
            <Table.HeaderCell>E-Posta</Table.HeaderCell>
            <Table.HeaderCell>Cep Telefonu</Table.HeaderCell>
            <Table.HeaderCell>Web Sitesi</Table.HeaderCell>
            <Table.HeaderCell>Adresi</Table.HeaderCell>
            <Table.HeaderCell>Şehir</Table.HeaderCell>
            <Table.HeaderCell>Şirket Adı</Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {users.map((user) => (
            <Table.Row key={user.id}>
              <Table.Cell>{user.id}</Table.Cell>
              <Table.Cell>{user.name}</Table.Cell>
              <Table.Cell>{user.username}</Table.Cell>
              <Table.Cell>{user.email}</Table.Cell>
              <Table.Cell>{user.phone}</Table.Cell>
              <Table.Cell>{user.website}</Table.Cell>
              <Table.Cell>{`${user.address.street} ${user.address.suite}`}</Table.Cell>
              <Table.Cell>{user.address.city}</Table.Cell>
              <Table.Cell>{user.company.name}</Table.Cell>
            </Table.Row>
          ))}
        </Table.Body>

        <Table.Footer>
          <Table.Row>
            <Table.HeaderCell colSpan="3">
              <Menu floated="right" pagination>
                <Menu.Item as="a" icon>
                  <Icon name="chevron left" />
                </Menu.Item>
                <Menu.Item as="a">1</Menu.Item>
                <Menu.Item as="a">2</Menu.Item>
                <Menu.Item as="a">3</Menu.Item>
                <Menu.Item as="a">4</Menu.Item>
                <Menu.Item as="a" icon>
                  <Icon name="chevron right" />
                </Menu.Item>
              </Menu>
            </Table.HeaderCell>
          </Table.Row>
        </Table.Footer>
      </Table>
    </div>
  );
}

export default UserList;
