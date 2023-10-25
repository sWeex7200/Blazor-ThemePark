window.initializeMap = function () {
    var map = L.map("map").setView([51.505, -0.09], 13);

    L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", {
        maxZoom: 19,
        attribution: "© <a href='https://www.openstreetmap.org/copyright'>OpenStreetMap</a> contributors"
    }).addTo(map);

    // Call initializeMap function with a delay of 100 milliseconds
    setTimeout(function () {
        initializeMap();
    }, 100);
};
