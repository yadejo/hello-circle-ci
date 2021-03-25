import { useEffect, useState } from 'react';
import { Movie } from './components/Movie';
import { get } from './api'

function App() {
  const [movies, setMovies] = useState([]);

  useEffect(() => {
    get("movies").then(setMovies);
  }, [])

  return (
   <div style={{display: "flex", flexWrap: 'wrap', justifyContent: ''}}>
     {
       movies.map(movie => <Movie {...movie} />)
     }
   </div>
  );
}


export default App;
