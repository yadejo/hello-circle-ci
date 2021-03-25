import { useState, useEffect } from 'react';
import { get } from '../api'
import { Movie, LoadingSpinner, MovieList } from '../components'

export function MoviesContainer() {
    const [movies, setMovies] = useState([]);
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        setLoading(true);
        setTimeout(() => {
            get("movies").then(movies => setMovies(movies)).then(() => setLoading(false));
        }, 1000)
    }, []);

    return (
        loading ? <LoadingSpinner /> : <MovieList movies={movies} />
    )
}