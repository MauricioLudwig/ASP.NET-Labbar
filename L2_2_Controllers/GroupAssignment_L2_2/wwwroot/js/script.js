$(document).ready(function () {
    $('.removeLink').click(function () {
        $('body').fadeOut('3000', function () {
            $(this).fadeIn('slow');
        });
    });
});