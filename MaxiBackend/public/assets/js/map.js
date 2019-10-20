mapboxgl.accessToken = `your mapbox access token here`;

const coords = [14.363250, 46.238220];
const map = new mapboxgl.Map({
    container: "map",
    style: "mapbox://styles/mapbox/streets-v11",
    center: coords,
    zoom: 17.5
});
const marker = new mapboxgl.Marker().setLngLat(coords).addTo(map);