import axios from "axios";

// fake api
export default class UserService {
  getUsers() {
    return axios.get("https://jsonplaceholder.typicode.com/users");
  }
}