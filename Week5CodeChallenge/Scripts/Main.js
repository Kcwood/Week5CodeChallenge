//Load the dom into a jQuery object
//after its fully loaded (.ready())
$(document).ready(function () {
    //selecting my tab links
    $('.about li').on('click', function () {
        //When we click on out li,run this function
        //Get the url from data-url for this li
        var url = $(this).data('url');
        //making an Ajax get request to the url 
        $.get(url, function (data) {
            //selecting our tab content area
            $('#tabContent').html(data);
        });
        //remove the current active tab
        $('.about li').removeClass('active');
        //add the active class to our current tab
        $(this).addClass('active');
    });
});