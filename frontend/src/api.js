console.log(process.env);

export const get = async (endpoint) => {
    console.log(process.env);
    const uri = process.env.REACT_APP_MOVIES_API_BASE_URI + endpoint;
    return fetch(uri).then(res => res.json());
}