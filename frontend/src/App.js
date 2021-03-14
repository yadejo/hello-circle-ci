import { useEffect, useState } from 'react';
import { Movie } from './components/Movie';

function App() {
  const [movies, setMovies] = useState([]);
  
  useEffect(() => {
    fetchMovies().then(setMovies);
  }, [])

  return (
   <div>
     {
       movies.map(movie => <Movie {...movie} />)
     }
   </div>
  );
}

async function fetchMovies() {
  const response = await fetch("https://localhost:5001/api/movies");
  return await response.json();
}

export default App;
