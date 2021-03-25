import './MovieList.css';
import { Movie } from './Movie';

export function MovieList({ movies }) {
    return (
        <ul className='MovieList'>
            {
                movies.map((movie, index) => (
                    <li>
                        <Movie {...movie} />
                    </li>
                ))
            }
        </ul>
    );
}