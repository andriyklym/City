﻿function initMap(ad) {
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 17,
        center: { lat: -34.397, lng: 150.644 }
    });
    var geocoder = new google.maps.Geocoder();


    geocodeAddress(geocoder, map, ad);

}

function geocodeAddress(geocoder, resultsMap, ad) {

    var address = "Наукова, Львів, Україна";
    address = decodeURIComponent(address);
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === 'OK') {
            resultsMap.setCenter(results[0].geometry.location);

            var marker = new google.maps.Marker({
                map: resultsMap,
                position: results[0].geometry.location
            });
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}