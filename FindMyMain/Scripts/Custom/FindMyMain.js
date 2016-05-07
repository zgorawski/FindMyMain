function processAnswer(answerData) {
    
    alert(answerData.Answer);

    var chatMessage = 
        '<li class="row">' +
            '<div class="media">' +
                '<div class="media-left media-middle">' +
                    '<img src="http://ddragon.leagueoflegends.com/cdn/6.8.1/img/champion/Aatrox.png" class="img-circle media-left media-middle fmm-img50" />' +
                '</div>' +
                '<div class="media-body">' +
                    '<p class="fmm-chatMessage">' + answerData.Answer + '</p>' +
                '</div>' +
            '</div>' +
        '</li>';

    $('#fmm-chat').append(chatMessage);
}

// quick search regex
var qsRegex;

// init Isotope
var $grid = $('#fmm-grid').isotope({
    itemSelector: '.championItem',
    layoutMode: 'fitRows',
    filter: function () {
        return qsRegex ? $(this).text().match(qsRegex) : true;
    }
});

// use value of search field to filter
var $quicksearch = $('#fmm-filter').keyup(debounce(function () {
    qsRegex = new RegExp($quicksearch.val(), 'gi');
    $grid.isotope();
}, 200));

// debounce so filtering doesn't happen every millisecond
function debounce(fn, threshold) {
    var timeout;
    return function debounced() {
        if (timeout) {
            clearTimeout(timeout);
        }
        function delayed() {
            fn();
            timeout = null;
        }
        timeout = setTimeout(delayed, threshold || 100);
    }
}