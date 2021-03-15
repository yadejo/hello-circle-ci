import './Movie.css';

export function Movie({ title, rating, posterUri, onClick }) {
    return (
        <article onClick={onClick} className="Movie">
            <img src={posterUri} />
            <h1>{title}</h1>
            <StarRating rating={rating} />
        </article>
    )
}

function StarRating({rating}) {
    const stars = [];
    for(let i = 0; i < rating; i++) {
        stars.push(<span className="StarRating_star"></span>);
    }
    return (
        <div className="StarRating">
            {stars}
        </div>
    )
}