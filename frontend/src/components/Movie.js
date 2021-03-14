import './Movie.css';

export function Movie({ title, rating, onClick }) {
    return (
        <article onClick={onClick}>
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