$('.delete-button').click(function() {
    var id = $('.active').find("td").eq(0).html();
    var tableClass = $('.active').closest('table').attr('class');
    $.ajax({
        url: "/Content/ListBook",
        data: { contentId: id, tableClass: tableClass },
        type: "POST",
        success: function(data) {
            $('.active').css('visibility', 'collapse');
        },
        error: function() {
            alert("ошибка при удалении");
        }
    });
});