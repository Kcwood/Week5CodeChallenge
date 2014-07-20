$(document).ready(function () {
    $('.tabset>li>a').on('click', function () {
        var clicked = $(this).data('id');
        var active = $('.tabset>li.active>a').data('id');
        if (clicked !== active) {
            $('.tableset>li.active').removeClass('active');
            $(this).parent().addClass('active');
            $('#' + active).fadeOut(200, function () {
                $('#' + clicked).fadeIn(200, function () {
                    $('#' + clicked).removeClass('hide');
                    $('#' + active).addClass('hide');
                });
            });
        }
    });
});