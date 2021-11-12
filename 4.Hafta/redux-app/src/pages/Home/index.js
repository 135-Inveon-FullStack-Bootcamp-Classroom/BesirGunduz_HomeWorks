import { useEffect } from "react";

import "./styles.css";
import Masonry from "react-masonry-css";

import { useSelector, useDispatch } from "react-redux";
import { fetchCharacters } from "../../redux/charactersSlice";

function Home() {
  const characters = useSelector((state) => state.characters.items);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(fetchCharacters());
  }, [dispatch]);

  return (
    <div>
      <Masonry
        breakpointCols={4}
        className="my-masonry-grid"
        columnClassName="my-masonry-grid_column"
      >
        {characters.map((character) => (
          <div key={character.char_id}>
            <img
              alt={character.name}
              src={character.img}
              className="character"
            />
          </div>
        ))}
      </Masonry>
    </div>
  );
}

export default Home;
