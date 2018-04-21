$(document).ready(function() {
    var scroll_pos = 0;
    $window = $(window);
    $(document).scroll(function() {
        scroll_pos = $(this).scrollTop();
        if (scroll_pos > 70) {
            $(".navbar-nav>li>a").css('color', '#6c6767');
            $(".navbar-inverse").css('background-color', 'white');
            $(".navbar-inverse").addClass('card');
            $(".navbar-nav>li").animate({'margin-top': '-12px'});

        } else {
            $(".navbar-inverse").css('background-color', 'transparent');
            $(".navbar-inverse").removeClass('card');
            $(".navbar-nav>li>a").css('color', 'white');
        }
        if ($window.width() < 767) {
            $(".navbar-inverse").css('background-color', 'rgb(21, 113, 146)');
            $(".navbar-nav>li>a").css('color', 'white');
        }
    });

    
});