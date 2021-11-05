import React from "react";
import { Button, Container, Menu } from "semantic-ui-react";

function Navi() {
  return (
    <div>
      <Menu inverted fixed="top">
        <Container>
          <Menu.Item name="Ana Sayfa" />
          <Menu.Menu position="right">
            <Menu.Item>
              <Button primary>Giriş Yap</Button>
            </Menu.Item>
          </Menu.Menu>
        </Container>
      </Menu>
    </div>
  );
}

export default Navi;
