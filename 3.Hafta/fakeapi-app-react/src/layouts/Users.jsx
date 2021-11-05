import { useState, useEffect } from "react";
import { Menu } from "semantic-ui-react";
import UserService from "../services/UserService";

function Users() {
  const [users, setUsers] = useState([]);

  useEffect(() => {
    let userService = new UserService();
    userService.getUsers().then((result) => setUsers(result.data));
  });
  return (
    <div>
      <Menu pointing vertical>
        {users.map((user, index) => (
          <Menu.Item key={index} name={user.name} />
        ))}
      </Menu>
    </div>
  );
}

export default Users;
