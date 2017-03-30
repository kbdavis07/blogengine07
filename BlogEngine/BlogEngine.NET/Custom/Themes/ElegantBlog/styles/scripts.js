$(document).ready(function () {
    $('.GlobalNav li:has(ul)').find("A:first").addClass('Sub');
    $('.GlobalNav ul ul').hide();
    $('.GlobalNav ul li').hover(function () { $('ul:first', this).stop(true, true).css('visibility', 'visible').fadeToggle(300); });
    $('.ClosedSearch').click(function () {
        $('.Social .Search').addClass('OpenedSearch');
        $('#BtnShow').hide();
        $('.GlobalSearch').animate({
            right: '0'
        });
        $('.GlobalSearch input[type=text]').focus(function () {
            $(this).val() == '';
        });
        $('.BtnCloseSearch').show();
    });
    $('.GlobalSearch input[type=text]').blur(function () {
        $('.Social .Search').removeClass('OpenedSearch');
        $('#BtnShow').show();
        $('.GlobalSearch').animate({
            right: '32'
        });
        $('.BtnCloseSearch').hide();
    });
    $('.BtnCloseSearch, .Container, .GlobalNav').click(function () {
        $('.Social .Search').removeClass('OpenedSearch');
        $('#BtnShow').show();
        $('.GlobalSearch').animate({
            right: '32'
        });
        $('.BtnCloseSearch').hide();
    });
    $('.BtnNavigations').click(function () {
        $('.Search-Navigation').toggle();
    });
    $('#BackTop').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 800);
        return false;
    });
    if ($.trim($('#commentlist').html()) == '') {
        $('#commentlist').hide();
    }
});